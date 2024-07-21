using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("http://fischhaus.com/");
        Debug.Log("is this working?");
    }

}
