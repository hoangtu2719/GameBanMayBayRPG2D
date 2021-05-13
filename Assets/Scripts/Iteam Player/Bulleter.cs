using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulleter : MonoBehaviour
{
    public float speedbullet;
    public int bulletplay;
    private Rigidbody2D mybody;
    void Start()
    {

    }
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        bulletplay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(0f, -speedbullet);
        /* transform.Rotate(0, 3, 0);*/
    }

    void OnTriggerEnter2D(Collider2D targe)
    {
        if (targe.tag == "Player")
        {
            bulletplay += 1;
            if (GamePlay.instance != null)
            {
                GamePlay.instance.setbullet(bulletplay);
                Destroy(gameObject);
            }
            Destroy(gameObject, 0.1f);
        }
        if (targe.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
