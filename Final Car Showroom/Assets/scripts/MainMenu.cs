using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Marker()
    {
        SceneManager.LoadScene(1);
    }
    public void Markeress()
    {
        SceneManager.LoadScene(2);
    }
}