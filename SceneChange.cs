using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //scene name
    public string sceneName;


    void OnTriggerEnter()
    {
        //rilancimi
        EditorSceneManager.LoadScene(sceneName);
    }
}
