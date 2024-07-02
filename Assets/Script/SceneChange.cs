using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SceneName, SerializeField]
    private string sceneName;

    public void Chnage()
    {
        SceneManager.LoadScene(sceneName);
    }
}
