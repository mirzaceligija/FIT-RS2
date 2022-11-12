import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';

class SignUpFooterWidget extends StatelessWidget {
  const SignUpFooterWidget({
    Key? key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        const Text("OR"),
        TextButton(
          onPressed: () {},
          child: Text.rich(TextSpan(children: [
            TextSpan(
              text: tAlreadyHaveAnAccount,
              style: Theme.of(context).textTheme.bodyText1,
            ),
            TextSpan(text: tSignIn.toUpperCase())
          ])),
        )
      ],
    );
  }
}