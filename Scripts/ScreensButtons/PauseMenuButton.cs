using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButton : MonoBehaviour
{
    public HUDscreen hudscreen;
    public PauseScreen pausescreen;

    public void Pause()
    {
        hudscreen.Setup();
        pausescreen.Setup();
    }
    public void BackPause()
    {
        hudscreen.PowerOn();
        pausescreen.PowerOff();
    }
}
