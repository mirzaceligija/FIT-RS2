import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:projectwemobile/src/constants/colors.dart';
import 'package:projectwemobile/src/constants/image_strings.dart';
import 'package:projectwemobile/src/constants/sizes.dart';
import 'package:projectwemobile/src/constants/text_strings.dart';

class WelcomeScreen extends StatelessWidget {
  static const String routeName = "/welcome";

  const WelcomeScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    var height = MediaQuery.of(context).size.height;
    return Scaffold(
        body: Container(
      padding: EdgeInsets.all(tDefaultSize),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: [
          Image(image: AssetImage(tWelcomeScreenImage), height: height * 0.6,),
          Column(
            children: [
              Text(tWelcomeTitle, style: Theme.of(context).textTheme.headline3),
              Text(
                tWelcomeSubTitle,
                style: Theme.of(context).textTheme.bodyText1,
                textAlign: TextAlign.center,
              ),
            ],
          ),
          Row(
            children: [
              Expanded(child: OutlinedButton(onPressed: () {},
               child: Text(tSignIn.toUpperCase()))),
              SizedBox(width: 10.0),
              Expanded(child: ElevatedButton(onPressed: () {}, 
              
              child: Text(tSignUp.toUpperCase()))),
            ],
          )
        ],
      ),
    ));
  }
}
