using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [SerializeField] private float speed=1.0f;
    [SerializeField] private float jumpForce = 1.0f;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        foreach(RaycastHit2D rh2d in Physics2D.RaycastAll(transform.position,
                                                          Vector2.down,1.5f))
                                                          {
                                                            if(rh2d.collider.CompareTag("Ground") && Input.GetButtonDown("Jump")){
                                                                rb2d.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
                                                            }
                                                          }
            
        
        
        rb2d.velocity = new Vector2(move*speed, 
                                    rb2d.velocity.y);

    }
}
