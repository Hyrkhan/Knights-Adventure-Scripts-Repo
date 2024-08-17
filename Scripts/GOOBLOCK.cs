using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOOBLOCK : MonoBehaviour
{

    public float MoveSpeed = 1f;
    Rigidbody2D rb;
    public OverScreen over;
    public HUDscreen hudscreen;
    public AudioSource audioOver;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (isFacingRight())
        {
            rb.velocity = new Vector2(MoveSpeed, 0f);
        }
        else
        {
            rb.velocity = new Vector2(-MoveSpeed, 0f);
        }
    }
    private bool isFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            over.Setup();
            hudscreen.Setup();
            audioOver.Play();

        }
    }

}
