import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/colors.dart';
import 'package:projectwemobile/src/constants/image_strings.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';

class DashboardAppBar extends StatelessWidget implements PreferredSizeWidget {
  const DashboardAppBar({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return AppBar(
      leading: const Icon(Icons.menu, color: Colors.black),
      title: Text(tAppName, style: Theme.of(context).textTheme.headline4),
      centerTitle: true,
      elevation: 0,
      backgroundColor: Colors.transparent,
      actions: [
        Container(
          margin: const EdgeInsets.symmetric(horizontal: 20, vertical: 7),
          child: IconButton(
            onPressed: () {},
            icon: Icon(Icons.account_circle_rounded, size: 24,),
          ),
        ),
      ],
    );
  }
  
  @override
  // TODO: implement preferredSize
  Size get preferredSize => Size.fromHeight(55);
}