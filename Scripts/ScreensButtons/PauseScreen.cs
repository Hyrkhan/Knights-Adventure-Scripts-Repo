using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);

    }
    public void PowerOff()
    {
        gameObject.SetActive(false);
    }
}
