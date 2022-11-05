import 'package:flutter/material.dart';

void main() => runApp(MaterialApp(
      debugShowCheckedModeBanner: true,
      home: HomePage(),
    ));

class HomePage extends StatelessWidget {
  const HomePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
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
                                color: Colors.blue,
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
                    ElevatedButton(
                      style: ElevatedButton.styleFrom(
                        primary: Colors.blue,
                        minimumSize: const Size.fromHeight(50),
                      ),
                      onPressed: () {},
                      child: const Text(
                        'Login',
                        style: TextStyle(fontSize: 16),
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
