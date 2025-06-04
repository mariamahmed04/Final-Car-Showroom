using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(1);
    }
    public void LoadSceneByName2(string sceneName)
    {
        SceneManager.LoadScene(2);
    }
}
