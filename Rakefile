ROOT = `pwd`.chomp
UNITY_PRJ_DIR = "#{ROOT}/unity_project"
ANDROID_PRJ_DIR = "#{ROOT}/NativeAndroid"
AAR_SRC_FPATH = "#{ANDROID_PRJ_DIR}/library/build/outputs/aar/library-release.aar"
AAR_DST_FPATH = "#{UNITY_PRJ_DIR}/Assets/Plugins/library-release.aar"

UNITY = "/Applications/Unity/Unity.app/Contents/MacOS/Unity"
UNITY_BUILD_METHOD_AND = 'BuildScript.Build'

build_cmd = [
  UNITY,
  "-quit -batchmode",
#  "-nographics",
  "-buildTarget android",
  "-projectPath #{UNITY_PRJ_DIR}",
  "-executeMethod #{UNITY_BUILD_METHOD_AND}"
].join(' ')

task :default do
  Dir.chdir(ANDROID_PRJ_DIR) do
      puts `./gradlew library:assemble`
  end
  cp AAR_SRC_FPATH, AAR_DST_FPATH
  sh build_cmd do |ok, res|
      if not ok
          abort 'operation failed'
      end
  end
end

