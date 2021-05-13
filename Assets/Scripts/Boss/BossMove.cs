using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform leftpoint, rightpoint;
    public float Speed;
    private float leftx, rightx;
    private bool Faceleft = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        leftx = leftpoint.position.x;
        rightx = rightpoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }
    void Movement()
    {
        if (Faceleft)
        {
            //transform.position = new Vector3(transform.position.x * Speed, transform.position.y);
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            if (transform.position.x < leftx)
            {
                //transform.localScale = new Vector3(-1f, 1f, 1);
                //transform.position = new Vector3(transform.position.x * Speed, transform.position.y);
                Faceleft = false;
            }
        }
        else
        {
            //transform.position = new Vector3(transform.position.x * Speed, transform.position.y);
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            if (transform.position.x > rightx)
            {
                //transform.localScale = new Vector3(1f, 1f, 1);
                
                Faceleft = true;
            }
        }
    }
}
