chcp 953
echo "始めるよー"
"C:\Program Files\Unity\Hub\Editor\2019.2.9f1\Editor\Unity.exe" -batchmode -quit -projectPath "C:\Users\yuuki\Documents\Develop\JenkinsAutoBuildForAndroid-Sample\JenkinsAutoBuild Sample" -executeMethod TestBuilder.BuildProjectAllSceneAndroid
echo "終わりだねー"
pause