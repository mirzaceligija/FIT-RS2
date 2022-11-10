import 'package:projectwemobile/src/features/authentication/model/user.dart';

import 'base_provider.dart';

class UserProvider extends BaseProvider<User> {
  UserProvider() : super("Users");

  @override
  User fromJson(data) {
    // TODO: Implement fromJson
    return User();
  }
}