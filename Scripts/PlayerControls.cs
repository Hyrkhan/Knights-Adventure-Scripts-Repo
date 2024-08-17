using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControls : MonoBehaviour
{
    
    public int parameters;
    Rigidbody2D rb;
    private float hInput;
    bool jumping;
    private Animator animate;
    bool faceRight = true;
    public AudioSource audioJump;
    public AudioSource audioCoin;
    public AudioSource audioBGM;
    public AudioSource audioKey;
    private int key;
    

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animate = gameObject.GetComponent<Animator>();
        audioBGM.Play();    
        hInput = Input.GetAxis("Horizontal");
        key = 0;
    }

    
    void Update()
    {
        hInput = CrossPlatformInputManager.GetAxis("Horizontal");
        //hInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(hInput * parameters, rb.velocity.y);
        
        animate.SetFloat("Speed", Mathf.Abs(hInput)); 

        if (hInput > 0 && !faceRight)
        {
            Flip();
            
        }
        else if (hInput < 0 && faceRight)
        {
            Flip();
            
        }

        /*if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            rb.AddForce(Vector2.up * 350);
            jumping = true;
            audioJump.Play();
        }
        */



        if (CrossPlatformInputManager.GetButtonDown("Jump") && !jumping)
        {
            rb.AddForce(Vector2.up * 350);
            jumping = true;
            audioJump.Play();
        }
        



    }


    void OnMouseDown()
    {
        //rb.AddForce(Vector2.up * 400);
        //animate.SetTrigger("Press");
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        jumping = false;

        if(collision.gameObject.tag == "WALL" && key > 0)
        {
            Destroy(collision.gameObject);
            key--;
        }
        if(collision.gameObject.tag == "Platform")
        {
            gameObject.transform.parent = collision.gameObject.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collisions)
    {
        if(collisions.gameObject.tag == "Platform")
        {
            gameObject.transform.parent = null;
        }

    }

    void Flip()
    {
        faceRight = !faceRight;

        Vector2 cscale = transform.localScale;
        cscale.x *= -1;
        transform.localScale = cscale;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            audioCoin.Play();
        }
        if(other.gameObject.tag == "KEY")
        {
            Destroy(other.gameObject);
            audioKey.Play();
            key++;
        }
    }
    
}
