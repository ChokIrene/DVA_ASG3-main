using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    public void LoadMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainRoom"); 
    }

    public void LoadRoom1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Room1");
    }

    public void LoadRoom2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Room2"); 
    }

    public void LoadRoom3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Room3"); 
    }
}
