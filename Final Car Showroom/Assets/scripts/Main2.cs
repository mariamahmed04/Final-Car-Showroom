using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main2 : MonoBehaviour
{
    // Start is called before the first frame updat
    public void Marker()
    {
        SceneManager.LoadScene(1);
    }
    public void Markeress()
    {
        SceneManager.LoadScene(2);
    }
    public void Mainme()
    {
        SceneManager.LoadScene(0);
    }
}