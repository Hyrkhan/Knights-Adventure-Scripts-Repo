using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOORSCRIPT : MonoBehaviour
{
    public WINSCREEN winscreen;
    public HUDscreen hudscreen;
    public AudioSource audioDoor;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            winscreen.Setup();
            hudscreen.Setup();
            audioDoor.Play();
        }
    }

}
