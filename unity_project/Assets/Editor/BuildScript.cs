using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public static class BuildScript
{
	[MenuItem("Build/Build")]
	public static void Build()
	{
		var scenes = EditorBuildSettings.scenes;
		List<string> sceneList = new List<string>();
		foreach (var scene in scenes)
		{
			if (scene.enabled)
				sceneList.Add(scene.path);
		}
		var sceneArray = sceneList.ToArray();

		PlayerSettings.Android.keystoreName = "qwe123.keystore";
		PlayerSettings.Android.keystorePass = "qwe123";
		PlayerSettings.Android.keyaliasName = "qwe123";
		PlayerSettings.Android.keyaliasPass = "qwe123";


		BuildPipeline.BuildPlayer (sceneArray, "build.apk", BuildTarget.Android, BuildOptions.Development);
	}
}
