using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDscreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(false);

    }
    public void PowerOn()
    {
        gameObject.SetActive(true);
    }
}
