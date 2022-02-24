using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    internal LevelManager levelManager;
    void Update()
    {
        Invoke("Game", 11.2f);
    }

    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}
