import 'package:flutter/material.dart';
import 'package:projectwemobile/provider/project_provider.dart';
import 'package:provider/provider.dart';

import '../../model/project.dart';

class ProjectListScreen extends StatefulWidget {
  static const String routeName = "/project";

  const ProjectListScreen({Key? key}) : super(key: key);

  @override
  State<ProjectListScreen> createState() => _ProjectListScreenState();
}

class _ProjectListScreenState extends State<ProjectListScreen> {
  ProjectProvider? _projectProvider = null;
  List<Project> data = [];

  @override
  void initState() {
    super.initState();
    _projectProvider = context.read<ProjectProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _projectProvider?.get(null);
    setState(() {
      data = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
            child: SingleChildScrollView(
      child: Container(
          child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Container(
              height: 200,
              child: GridView(
                gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                    crossAxisCount: 1,
                    childAspectRatio: 4 / 3,
                    crossAxisSpacing: 20,
                    mainAxisSpacing: 30),
                scrollDirection: Axis.horizontal,
                children: _buildProjectCardList(),
              ))
        ],
      )),
    )));
  }

  List<Widget> _buildProjectCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }

    List<Widget> list = data
        .map((x) => Container(
              child: Column(
                children: [
                  Text(x.name ?? ""),
                  Text(x.description ?? "")
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
