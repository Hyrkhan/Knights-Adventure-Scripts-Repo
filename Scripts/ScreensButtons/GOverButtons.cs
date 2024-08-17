using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOverButtons : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelScenes");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
