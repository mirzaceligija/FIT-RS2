import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';
import 'package:projectwemobile/src/features/projects/controllers/base_provider.dart';
import 'package:projectwemobile/src/features/projects/model/project.dart';

class ProjectProvider extends BaseProvider<Project> {
  ProjectProvider() : super("Projects");

  @override
  Project fromJson(data) {
    return Project.fromJson(data);
  }
}