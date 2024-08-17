using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaerieScript : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();     
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
    }


}
