import 'dart:io';

Future<Null> someFunction() async {
  var file = new File('/path/to/my/file');
  var now = new DateTime.now();
  if ((await file.lastModified()).isBefore(now)) print('before'); // LINT
}
