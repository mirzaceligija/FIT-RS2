import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import '../../widgets/master_screen.dart';

class AccountDetailsScreen extends StatefulWidget {
  static const String routeName = "/account_details";
  String id;

  AccountDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<AccountDetailsScreen> createState() => _AccountDetailsScreenState();
}

class _AccountDetailsScreenState extends State<AccountDetailsScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(child: Text(this.widget.id),),
    );
  }
}