adb connect 127.0.0.1:5555
set ANDROID_SERIAL=127.0.0.1:5555

adb root
adb forward tcp:52736 tcp:52736

adb shell "/data/local/tmp/ceserver/ceserver_x86"