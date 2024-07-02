using System;
using System.IO;
using UnityEditor;
using UnityEngine;


[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class SceneNameAttribute : PropertyAttribute
{
    public readonly string[] Name;

    public SceneNameAttribute()
    {
        var scene = EditorBuildSettings.scenes;
        Name = new string[scene.Length];
        for (int i = 0; i < scene.Length; i++)
        {
            var s = scene[i].path;
            var sceneName = Path.GetFileNameWithoutExtension(Path.GetFileName(s));
            Name[i] = sceneName;
        }
    }
}
