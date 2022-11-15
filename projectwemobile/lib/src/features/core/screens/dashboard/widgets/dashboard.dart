import 'package:flutter/material.dart';
import 'package:get/get_connect/http/src/utils/utils.dart';
import 'package:projectwemobile/src/constants/colors.dart';
import 'package:projectwemobile/src/constants/image_strings.dart';
import 'package:projectwemobile/src/constants/sizes.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';
import 'package:projectwemobile/src/features/core/screens/dashboard/widgets/banners.dart';
import 'package:projectwemobile/src/features/core/screens/dashboard/widgets/categories.dart';
import 'package:projectwemobile/src/features/core/screens/dashboard/widgets/projects.dart';
import 'package:projectwemobile/src/utils/utils.dart';
import 'package:projectwemobile/src/widgets/master_screen.dart';
import 'package:projectwemobile/src/widgets/projectwe_drawer.dart';

class Dashboard extends StatelessWidget {
  static const String routeName = "/dashboard";
  const Dashboard({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final textTheme = Theme.of(context).textTheme;

    return Scaffold(
        body: MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          padding: const EdgeInsets.all(tDashboardPadding),
          child:
              Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
            // Headings
            Text(
              tDashboardTitle,
              style: textTheme.bodyText2,
            ),
            Text(
              tDashboardHeading,
              style: textTheme.headline2,
            ),
            const SizedBox(
              height: tDashboardPadding,
            ),

            //Categories
            DashboardCategories(textTheme: textTheme),
            const SizedBox(height: tDashboardPadding),

            // Banners
            DashboardBanners(textTheme: textTheme),

            const SizedBox(height: tDashboardPadding),

            // Top Projects

            Text(tDashboardTopProjects,
                style: textTheme.headline4?.apply(fontSizeFactor: 1.2)),
            DashboardTopProjects(textTheme: textTheme)
          ]),
        ),
      ),
    ));
  }
}
