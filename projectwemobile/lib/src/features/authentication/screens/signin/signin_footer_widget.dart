import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:get/get_core/src/get_main.dart';
import 'package:projectwemobile/src/constants/sizes.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';
import 'package:projectwemobile/src/features/authentication/screens/signup/signup_screen.dart';

class SignInFooterWidget extends StatelessWidget {
  const SignInFooterWidget({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        const Text("OR"),
        const SizedBox(height: tFormHeight - 20),
        TextButton(
          onPressed: () => Get.to(() => SignUpScreen()),
          child: Text.rich(TextSpan(children: [
            TextSpan(
              text: tDontHaveAnAccount,
              style: Theme.of(context).textTheme.bodyText1,
            ),
            TextSpan(text: tSignUp, style: TextStyle(color: Colors.blue))
          ])),
        ),
      ],
    );
  }
}
