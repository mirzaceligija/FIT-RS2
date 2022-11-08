import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:projectwemobile/model/project.dart';
import 'package:projectwemobile/provider/base_provider.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

class ProjectProvider extends BaseProvider<Project> {
  ProjectProvider() : super("Projects");

  @override
  Project fromJson(data) {
    return Project.fromJson(data);
  }
}