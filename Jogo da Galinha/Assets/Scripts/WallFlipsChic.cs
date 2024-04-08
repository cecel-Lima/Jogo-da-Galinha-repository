using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFlipsChic : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chicken")
        {
            SpriteRenderer colSP = collision.gameObject.GetComponent<SpriteRenderer>();
            colSP.flipX = !colSP.flipX;
        }
    }
}
