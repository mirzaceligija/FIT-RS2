import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/colors.dart';
import 'package:projectwemobile/src/constants/image_strings.dart';
import 'package:projectwemobile/src/constants/sizes.dart';

class DashboardTopProjects extends StatelessWidget {
  const DashboardTopProjects({
    Key? key,
    required this.textTheme,
  }) : super(key: key);

  final TextTheme textTheme;

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: 200,
      child: ListView(
        shrinkWrap: true,
        scrollDirection: Axis.horizontal,
        children: [
          SizedBox(
            width: 320,
            height: 200,
            child: Padding(
              padding: EdgeInsets.only(right: 10, top: 5),
              child: Container(
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: tCardBgColor),
                padding: const EdgeInsets.all(10),
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Row(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Flexible(
                              child: Text(
                            "Flutter Crash Course",
                            style: textTheme.headline4,
                            maxLines: 2,
                            overflow: TextOverflow.ellipsis,
                          )),
                          Flexible(
                              child: Image(
                            image: AssetImage(tTopProjectImage1),
                            height: 110,
                          ))
                        ],
                      ),
                      Row(
                        children: [
                          ElevatedButton(
                              style: ElevatedButton.styleFrom(
                                  shape: const CircleBorder()),
                              onPressed: () {},
                              child: const Icon(Icons.play_arrow)),
                          const SizedBox(width: tDashboardPadding),
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text("3 Sections", style: textTheme.headline4, overflow: TextOverflow.ellipsis,),
                               Text("Programming languages", style: textTheme.bodyText2, overflow: TextOverflow.ellipsis,),
                            ],
                          )
                        ],
                      )
                    ]),
              ),
            ),
          ),
          SizedBox(
            width: 320,
            height: 200,
            child: Padding(
              padding: EdgeInsets.only(right: 10, top: 5),
              child: Container(
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: tCardBgColor),
                padding: const EdgeInsets.all(10),
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Row(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Flexible(
                              child: Text(
                            "Flutter Crash Course",
                            style: textTheme.headline4,
                            maxLines: 2,
                            overflow: TextOverflow.ellipsis,
                          )),
                          Flexible(
                              child: Image(
                            image: AssetImage(tTopProjectImage1),
                            height: 110,
                          ))
                        ],
                      ),
                      Row(
                        children: [
                          ElevatedButton(
                              style: ElevatedButton.styleFrom(
                                  shape: const CircleBorder()),
                              onPressed: () {},
                              child: const Icon(Icons.play_arrow)),
                          const SizedBox(width: tDashboardPadding),
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text("3 Sections", style: textTheme.headline4, overflow: TextOverflow.ellipsis,),
                               Text("Programming languages", style: textTheme.bodyText2, overflow: TextOverflow.ellipsis,),
                            ],
                          )
                        ],
                      )
                    ]),
              ),
            ),
          ),
          SizedBox(
            width: 320,
            height: 200,
            child: Padding(
              padding: EdgeInsets.only(right: 10, top: 5),
              child: Container(
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: tCardBgColor),
                padding: const EdgeInsets.all(10),
                child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Row(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Flexible(
                              child: Text(
                            "Flutter Crash Course",
                            style: textTheme.headline4,
                            maxLines: 2,
                            overflow: TextOverflow.ellipsis,
                          )),
                          Flexible(
                              child: Image(
                            image: AssetImage(tTopProjectImage1),
                            height: 110,
                          ))
                        ],
                      ),
                      Row(
                        children: [
                          ElevatedButton(
                              style: ElevatedButton.styleFrom(
                                  shape: const CircleBorder()),
                              onPressed: () {},
                              child: const Icon(Icons.play_arrow)),
                          const SizedBox(width: tDashboardPadding),
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text("3 Sections", style: textTheme.headline4, overflow: TextOverflow.ellipsis,),
                               Text("Programming languages", style: textTheme.bodyText2, overflow: TextOverflow.ellipsis,),
                            ],
                          )
                        ],
                      )
                    ]),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
