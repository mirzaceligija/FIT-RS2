import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/image_strings.dart';
import 'package:projectwemobile/src/constants/sizes.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';
import 'package:projectwemobile/src/features/authentication/screens/signin/signin_footer_widget.dart';
import 'package:projectwemobile/src/features/authentication/screens/signin/signin_form_widget.dart';
import 'package:projectwemobile/src/features/authentication/screens/signin/signin_header_widget.dart';

class SignInScreen extends StatelessWidget {
  static const String routeName = "/signin";
  const SignInScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;

    return SafeArea(
      child: Scaffold(
          body: SingleChildScrollView(
        child: Container(
          padding: EdgeInsets.all(tDefaultSize),
          child:
              Column(children: [
            SignInHeaderWidget(),
            SignInForm(),
            SignInFooterWidget(),
          ]),
        ),
      )),
    );
  }
}
