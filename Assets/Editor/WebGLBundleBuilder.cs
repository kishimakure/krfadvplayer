using UnityEditor;
using UnityEngine;
using System.IO;

public class PureWebGLBuilder
{
    private static string outputDirectory = "Assets/WebGL_Bundles";

    [MenuItem("Custom/Pack WebGL Bundle")]
    static void BuildPureWebGLBundles()
    {
        if (!Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }


        BuildPipeline.BuildAssetBundles(
            outputDirectory, 
            BuildAssetBundleOptions.ChunkBasedCompression | BuildAssetBundleOptions.ForceRebuildAssetBundle, 
            BuildTarget.WebGL 
        );
    }
}