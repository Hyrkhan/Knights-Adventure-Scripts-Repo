using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverZone : MonoBehaviour
{
    public OverScreen over;
    public HUDscreen hudscreen;
    public AudioSource audioOver;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            over.Setup();
            hudscreen.Setup();
            audioOver.Play();
            
        }
    }
}
