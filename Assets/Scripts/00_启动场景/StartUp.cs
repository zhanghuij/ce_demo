using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
    public List<string>  _sceneNames;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
        InitScenes();
    }
    
    private void OnGUI()
    {
        foreach (var sceneName in _sceneNames)
        {
            if (GUILayout.Button(sceneName))
            {
                if (SceneManager.GetActiveScene().name != sceneName)
                {
                    SceneManager.LoadScene(sceneName);
                }
            }
        }    
    }

    private void InitScenes()
    {
        var sceneCount = SceneManager.sceneCountInBuildSettings;
        for (int i = 0; i < sceneCount; i++)
        {
            var scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            var sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);
            _sceneNames.Add(sceneName);
        }
    }
}
