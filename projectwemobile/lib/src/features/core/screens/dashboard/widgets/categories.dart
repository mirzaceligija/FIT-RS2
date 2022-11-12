
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/colors.dart';

class DashboardCategories extends StatelessWidget {
  const DashboardCategories({
    Key? key,
    required this.textTheme,
  }) : super(key: key);

  final TextTheme textTheme;

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: 45,
      child: ListView(
        shrinkWrap: true,
        scrollDirection: Axis.horizontal,
        children: [
          SizedBox(
            width: 170,
            height: 50,
            child: Row(children: [
              Container(
                width: 45,
                height: 45,
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: tDarkColor),
                child: Center(
                  child: Text(
                    "JS",
                    style: textTheme.headline6
                        ?.apply(color: Colors.white),
                  ),
                ),
              ),
              const SizedBox(
                width: 5,
              ),
              Flexible(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Text(
                      "Java Script",
                      style: textTheme.headline6,
                      overflow: TextOverflow.ellipsis,
                    ),
                    Text("10 lessons",
                        style: textTheme.bodyText2,
                        overflow: TextOverflow.ellipsis)
                  ],
                ),
              )
            ]),
          ),
          SizedBox(
            width: 170,
            height: 50,
            child: Row(children: [
              Container(
                width: 45,
                height: 45,
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: tDarkColor),
                child: Center(
                  child: Text(
                    "JS",
                    style: textTheme.headline6
                        ?.apply(color: Colors.white),
                  ),
                ),
              ),
              const SizedBox(
                width: 5,
              ),
              Flexible(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Text(
                      "Java Script",
                      style: textTheme.headline6,
                      overflow: TextOverflow.ellipsis,
                    ),
                    Text("10 lessons",
                        style: textTheme.bodyText2,
                        overflow: TextOverflow.ellipsis)
                  ],
                ),
              )
            ]),
          ),
          SizedBox(
            width: 170,
            height: 50,
            child: Row(children: [
              Container(
                width: 45,
                height: 45,
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: tDarkColor),
                child: Center(
                  child: Text(
                    "JS",
                    style: textTheme.headline6
                        ?.apply(color: Colors.white),
                  ),
                ),
              ),
              const SizedBox(
                width: 5,
              ),
              Flexible(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Text(
                      "Java Script",
                      style: textTheme.headline6,
                      overflow: TextOverflow.ellipsis,
                    ),
                    Text("10 lessons",
                        style: textTheme.bodyText2,
                        overflow: TextOverflow.ellipsis)
                  ],
                ),
              )
            ]),
          ),
        ],
      ),
    );
  }
}


