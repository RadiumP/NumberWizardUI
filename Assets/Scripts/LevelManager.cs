﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public void LoadNewLevel(string name)
    {
        Debug.Log("Level load requested" + name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
    }

}