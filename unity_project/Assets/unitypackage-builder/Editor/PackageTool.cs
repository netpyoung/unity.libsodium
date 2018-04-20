using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    private static void UpdatePackage()
    {
        const string VERSION = "0.0.1";
        AssetDatabase.ExportPackage(
            new[] {"Assets/unity.libsodium"},
            $"../libsodium-{VERSION}.unitypackage",
            ExportPackageOptions.Recurse
        );
    }
}