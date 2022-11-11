import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/sizes.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';

class SignInFooterWidget extends StatelessWidget {
  const SignInFooterWidget({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.center,
      children: [
        const Text("OR"),
        const SizedBox(height: tFormHeight - 20),
        TextButton(
          onPressed: () {},
          child: Text.rich(
            TextSpan(
                text: tDontHaveAnAccount,
                style: Theme.of(context).textTheme.bodyText1,
                children: const [
                  TextSpan(text: tSignUp, style: TextStyle(color: Colors.blue))
                ]),
          ),
        ),
      ],
    );
  }
}