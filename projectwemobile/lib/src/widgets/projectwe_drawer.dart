import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:projectwemobile/main.dart';
import 'package:projectwemobile/src/features/projects/screens/project_list_screen.dart';
import 'package:provider/provider.dart';


class projectWeDrawer extends StatelessWidget {
  projectWeDrawer({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          ListTile(
            title: Text('Home'),
            onTap: () {
               Navigator.popAndPushNamed(context, ProjectListScreen.routeName);
            },
          ),
          ListTile(
            title: Text('Account'),
          ),
          ListTile(
            title: Text('Sign Out'),
            onTap: () {
               Navigator.pushAndRemoveUntil(
                context,
                MaterialPageRoute(builder: (context) => HomePage()),
                (Route<dynamic> route) => false,
              );
            },
          ),
        ],
      ),
    );
  }
}