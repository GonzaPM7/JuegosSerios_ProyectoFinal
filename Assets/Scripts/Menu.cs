﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void Level1()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
