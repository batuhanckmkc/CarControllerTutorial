using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Scene : MonoBehaviour
{
    public void Changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
