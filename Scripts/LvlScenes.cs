using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlScenes : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
}
