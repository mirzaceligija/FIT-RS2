import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:projectwemobile/provider/project_provider.dart';
import 'package:projectwemobile/screens/projects/project_list_screen.dart';
import 'package:provider/provider.dart';

void main() => runApp(MultiProvider(
        providers: [
          ChangeNotifierProvider(create: (_) => ProjectProvider()),
        ],
        child: MaterialApp(
          debugShowCheckedModeBanner: true,
          home: HomePage(),
          onGenerateRoute: ((settings) {
            if (settings.name == ProjectListScreen.routeName) {
              return MaterialPageRoute(
                  builder: ((context) => ProjectListScreen()));
            }
          }),
        )));

class HomePage extends StatelessWidget {
  const HomePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          backgroundColor: Colors.deepPurple,
          title: Text("Project We"),
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
                      decoration: InputDecoration(hintText: "Username"),
                    )),
                    Container(
                        child: TextField(
                      decoration: InputDecoration(hintText: "Password"),
                    )),
                    Container(
                      height: 50,
                      width: MediaQuery.of(context).size.width,
                      margin: EdgeInsets.fromLTRB(40, 40, 40, 0),
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color: Colors.amber),
                      child: InkWell(
                        onTap: () async {
                          try {
                            //Authorization.username = _usernameController.text;
                            //Authorization.password = _passwordController.text;

                            //await _userProvider.get();
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
