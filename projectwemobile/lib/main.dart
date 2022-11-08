import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:projectwemobile/provider/project_provider.dart';
import 'package:projectwemobile/provider/user_provider.dart';
import 'package:projectwemobile/screens/account/account_details.dart';
import 'package:projectwemobile/screens/projects/project_details_screen.dart';
import 'package:projectwemobile/screens/projects/project_list_screen.dart';
import 'package:projectwemobile/utils/utils.dart';
import 'package:provider/provider.dart';

void main() => runApp(MultiProvider(
        providers: [
          ChangeNotifierProvider(create: (_) => ProjectProvider()),
          ChangeNotifierProvider(create: (_) => UserProvider()),
        ],
        child: MaterialApp(
          theme: ThemeData(
              brightness: Brightness.light,
              primaryColor: Colors.deepPurple,
              textButtonTheme: TextButtonThemeData(
                  style: TextButton.styleFrom(
                      primary: Colors.teal,
                      textStyle: const TextStyle(
                          fontSize: 24, fontWeight: FontWeight.bold)))),
          debugShowCheckedModeBanner: true,
          home: HomePage(),
          onGenerateRoute: ((settings) {
            if (settings.name == ProjectListScreen.routeName) {
              return MaterialPageRoute(
                  builder: ((context) => ProjectListScreen()));
            }
            if (settings.name == AccountDetailsScreen.routeName) {
              return MaterialPageRoute(
                  builder: ((context) => AccountDetailsScreen("2")));
            }

            var uri = Uri.parse(settings.name!);
            if (uri.pathSegments.length == 2 &&
                "/${uri.pathSegments.first}" == ProjectDetailsScreen.routeName) {
              var id = uri.pathSegments[1];
              return MaterialPageRoute(
                  builder: (context) => ProjectDetailsScreen(id));
            }
          }),
        )));

class HomePage extends StatelessWidget {
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);

    return Scaffold(
        appBar: AppBar(
          title: Text("Project We"),
          backgroundColor: Colors.deepPurple,
        ),
        body: SingleChildScrollView(
            child: Column(
          children: [
            Padding(
                padding: EdgeInsets.fromLTRB(40, 200, 40, 100),
                child: (Column(
                  children: [
                    Padding(
                        padding: EdgeInsets.all(40),
                        child: (Text("Login",
                            style: TextStyle(
                                color: Colors.deepPurple,
                                fontSize: 32,
                                fontWeight: FontWeight.bold)))),
                    Container(
                        child: TextField(
                      controller: _usernameController,
                      decoration: InputDecoration(hintText: "Username"),
                    )),
                    Container(
                        child: TextField(
                      controller: _passwordController,
                      decoration: InputDecoration(hintText: "Password"),
                    )),
                    Container(
                      height: 50,
                      width: MediaQuery.of(context).size.width,
                      margin: EdgeInsets.fromLTRB(40, 40, 40, 0),
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color: Colors.teal),
                      child: InkWell(
                        onTap: () async {
                          try {
                            Authorization.username = _usernameController.text;
                            Authorization.password = _passwordController.text;

                            await _userProvider.getList();
                            Navigator.pushNamed(
                                context, ProjectListScreen.routeName);
                          } catch (e) {
                            showDialog(
                                context: context,
                                builder: (BuildContext context) => AlertDialog(
                                      title: Text("Error"),
                                      content: Text(e.toString()),
                                      actions: [
                                        TextButton(
                                          child: Text("Ok"),
                                          onPressed: () =>
                                              Navigator.pop(context),
                                        )
                                      ],
                                    ));
                          }
                        },
                        child: Center(child: Text("Login")),
                      ),
                    ),
                    Padding(
                        padding: EdgeInsets.all(40),
                        child: (Text("Forgot Password?",
                            style:
                                TextStyle(color: Colors.grey, fontSize: 16)))),
                  ],
                )))
          ],
        )));
  }
}
