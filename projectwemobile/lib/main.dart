import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projectwemobile/src/features/authentication/screens/splash_screen/splash_screen.dart';
import 'package:projectwemobile/src/features/projects/controllers/project_provider.dart';
import 'package:projectwemobile/src/features/projects/controllers/user_provider.dart';
import 'package:projectwemobile/src/features/authentication/screens/on_boarding/on_boarding_screen.dart';
import 'package:projectwemobile/src/features/authentication/screens/welcome/welcome_screen.dart';
import 'package:projectwemobile/src/features/projects/screens/project_details_screen.dart';
import 'package:projectwemobile/src/features/projects/screens/project_list_screen.dart';
import 'package:projectwemobile/src/utils/theme/theme.dart';
import 'package:projectwemobile/src/utils/utils.dart';
import 'package:provider/provider.dart';


void main() => runApp(const App());

class App extends StatelessWidget {
  const App({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GetMaterialApp(
      theme: TAppTheme.lightTheme,
          themeMode: ThemeMode.light,
          debugShowCheckedModeBanner: true,
          home: SplashScreen(),
    );
  }
}

/*
void main() => runApp(MultiProvider(
        providers: [
          ChangeNotifierProvider(create: (_) => ProjectProvider()),
          ChangeNotifierProvider(create: (_) => UserProvider()),
        ],
        child: MaterialApp(
          theme: TAppTheme.lightTheme,
          themeMode: ThemeMode.light,
          debugShowCheckedModeBanner: true,
          home: SplashScreen(),
          onGenerateRoute: ((settings) {
            if (settings.name == ProjectListScreen.routeName) {
              return MaterialPageRoute(
                  builder: ((context) => ProjectListScreen()));
            }
            else if (settings.name == OnBoardingScreen.routeName) {
              return MaterialPageRoute(
                  builder: ((context) => OnBoardingScreen()));
            }
            else if (settings.name == WelcomeScreen.routeName) {
              return MaterialPageRoute(
                  builder: ((context) => WelcomeScreen()));
            }


            var uri = Uri.parse(settings.name!);
            if (uri.pathSegments.length == 2 &&
                "/${uri.pathSegments.first}" ==
                    ProjectDetailsScreen.routeName) {
              var id = uri.pathSegments[1];
              return MaterialPageRoute(
                  builder: (context) => ProjectDetailsScreen(id));
            }
          }),

        )));
                  */

/*
class HomePage extends StatelessWidget {
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);

     Navigator.pushNamed(context, WelcomeScreen.routeName);

    return Scaffold(
        appBar: AppBar(
          title: const Text("Project We"),
        ),
        body: SingleChildScrollView(
            child: Container(
              padding: const EdgeInsets.all(20),
              child: Column(
                children: [
                  //Image(image: const AssetImage())
                ],
              )
        )));
  }
}

*/
/*

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

          */
