using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void Level1()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    public void Level1_2()
    {
        SceneManager.LoadScene("Nivel 1_2");
    }
    public void Level2_1()
    {
        SceneManager.LoadScene("Nivel 2_1");
    }
    public void Level2_2()
    {
        SceneManager.LoadScene("Nivel 2_2");
    }
    public void BossFinal()
    {
        SceneManager.LoadScene("Nivel Final");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
