import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projectwemobile/src/constants/colors.dart';
import 'package:projectwemobile/src/constants/image_strings.dart';
import 'package:projectwemobile/src/constants/sizes.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';
import 'package:projectwemobile/src/features/authentication/controllers/splash_screen_controller.dart';

class SplashScreen extends StatelessWidget {
  SplashScreen({Key? key}) : super(key: key);

  final splashScreenController = Get.put(SplashScreenController());

  @override
  Widget build(BuildContext context) {
    splashScreenController.startAnimation();
    return Scaffold(
      body: Stack(
        children: [
          Obx(
            () => AnimatedPositioned(
                top: splashScreenController.animate.value ? 0 : -30,
                left: splashScreenController.animate.value ? 0 : -30,
                duration: const Duration(milliseconds: 1600),
                child: Image(image: AssetImage(tSplashScreenIcon))),
          ),
          Obx(
            () => AnimatedPositioned(
                duration: const Duration(milliseconds: 1600),
                top: 80,
                left: splashScreenController.animate.value ? tDefaultSize : -80,
                child: AnimatedOpacity(
                  duration: const Duration(milliseconds: 1600),
                  opacity: splashScreenController.animate.value ? 1 : 0,
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        tAppName,
                        style: Theme.of(context).textTheme.headline3,
                      ),
                      Text(tAppTagline,
                          style: Theme.of(context).textTheme.headline2)
                    ],
                  ),
                )),
          ),
          Obx(
            () => AnimatedPositioned(
                duration: const Duration(milliseconds: 2400),
                bottom: splashScreenController.animate.value ? 200 : 0,
                child: AnimatedOpacity(
                    duration: const Duration(milliseconds: 2000),
                    opacity: splashScreenController.animate.value ? 1 : 0,
                    child: Image(
                      image: AssetImage(tSplashScreenImage),
                      height: 400,
                    ))),
          ),
          Obx(
            () => AnimatedPositioned(
                duration: const Duration(milliseconds: 2000),
                bottom: splashScreenController.animate.value ? 60 : 0,
                right: tDefaultSize,
                child: AnimatedOpacity(
                  duration: const Duration(milliseconds: 2000),
                  opacity: splashScreenController.animate.value ? 1 : 0,
                  child: Container(
                    width: tSplashScreenContainerSize,
                    height: tSplashScreenContainerSize,
                    decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(100),
                        color: tPrimaryColor),
                  ),
                )),
          ),
        ],
      ),
    );
  }
}
