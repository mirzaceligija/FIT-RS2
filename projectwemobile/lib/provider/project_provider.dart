import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:flutter/cupertino.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

import '../model/project.dart';

class ProjectProvider with ChangeNotifier {

  HttpClient client = new HttpClient();
  IOClient? http;

  ProjectProvider() {
    client.badCertificateCallback =(cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<Project>> get(dynamic searchObject) async {
    //var url = Uri.parse("http://10.0.2.2:5192/api/projects");
    var url = Uri.parse("http://localhost:5192/api/projects");

    String username = "manager";
    String password = "test";
    String basicAuth = "Basic ${base64Encode(utf8.encode('$username:$password'))}";

    var headers = {
      "Content-Type": "application/json",
      "Authorization": basicAuth
    };

    var response = await http!.get(url, headers: headers);

    if(response.statusCode < 400) {
      var data = jsonDecode(response.body);
      List<Project> list = data.map((x) => Project.fromJson(x)).cast<Project>().toList();
      return list;
    } else {
      throw Exception("User not allowed");
    }
  }
}