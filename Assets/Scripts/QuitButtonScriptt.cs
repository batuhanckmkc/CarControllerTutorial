using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonScriptt : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("Has exit game");
        Application.Quit();
    }
}
