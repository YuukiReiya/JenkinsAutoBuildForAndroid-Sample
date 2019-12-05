using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class TestBuilder
{
    // ビルド実行でAndroidのapkを作成する例
    [MenuItem("Tools/Build Project AllScene Android")]
    public static void BuildProjectAllSceneAndroid()
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android,BuildTarget.Android);
        List<string> allScene = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                allScene.Add(scene.path);
            }
        }
        PlayerSettings.applicationIdentifier = "com.yourcompany.newgame";
        PlayerSettings.statusBarHidden = true;
        BuildPipeline.BuildPlayer(
            allScene.ToArray(),
            "C:\\Users\\yuuki\\Documents\\Develop\\bin\\test.apk",
            BuildTarget.Android,
            BuildOptions.None
        );
    }
}