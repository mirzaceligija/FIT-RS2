import 'package:flutter/material.dart';
import 'package:projectwemobile/src/features/projects/controllers/project_provider.dart';
import 'package:projectwemobile/src/features/projects/model/project.dart';
import 'package:projectwemobile/src/features/projects/screens/project_details_screen.dart';
import 'package:projectwemobile/src/widgets/master_screen.dart';
import 'package:provider/provider.dart';


class ProjectListScreen extends StatefulWidget {
  static const String routeName = "/project";

  const ProjectListScreen({Key? key}) : super(key: key);

  @override
  State<ProjectListScreen> createState() => _ProjectListScreenState();
}

class _ProjectListScreenState extends State<ProjectListScreen> {
  ProjectProvider? _projectProvider = null;
  List<Project> data = [];
  TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _projectProvider = context.read<ProjectProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _projectProvider?.getList(null);
    setState(() {
      data = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              _buildProjectSearch(),
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
                ),
              )
            ],
          ),
        ),
      )
    );
  }

   Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text("Projects", style: TextStyle(color: Colors.black, fontSize: 24, fontWeight: FontWeight.bold),),
    );
  }

   Widget _buildProjectSearch() {
    return Row(
      children: [
        Expanded(
          child: Container(
            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: TextField(
              controller: _searchController,
              onSubmitted: (value) async {
                var tmpData = await _projectProvider?.getList({'name': value});
                setState(() {
                  data = tmpData!;
                });
              },
              decoration: InputDecoration(
                  hintText: "Search",
                  prefixIcon: Icon(Icons.search),
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(10),
                      borderSide: BorderSide(color: Colors.grey))),
            ),
          ),
        ),
        Container(
          padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
          child: IconButton(
            icon: Icon(Icons.filter_list),
            onPressed: () async {
                var tmpData = await _projectProvider?.getList({'name': _searchController.text});
                setState(() {
                  data = tmpData!;
                });
            },
          ),
        )
      ],
    );
  }

  List<Widget> _buildProjectCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }

    List<Widget> list = data
        .map((x) => Container(
              child: Column(
                children: [
                  InkWell(
                    onTap: () {
                      Navigator.pushNamed(context, "${ProjectDetailsScreen.routeName}/${x.projectId}");
                    },
                    child: Container(
                      height: 100,
                      width: 100,
                      child: Text("Hello"),
                    ),
                  ),
                  Text(x.name ?? ""),
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
