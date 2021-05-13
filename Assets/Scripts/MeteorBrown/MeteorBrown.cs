using UnityEngine;

public class MeteorBrown : MonoBehaviour
{
    public float meteoriteSpeed;
    private Rigidbody2D mybody;
    // Start is called before the first frame update
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(0f, -meteoriteSpeed);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {

            if (GamePlay.instance != null)
            {
                GamePlay.instance.setlive(-1);
                GamePlay.instance.setbullet(-1);
                Destroy(gameObject);
            }
            if (GamePlay.instance.live < 0)
            {
                Destroy(target.gameObject);
                GamePlay.instance.PlaneDiedShowPanel(); // ke thua lop gamecontrolplay
            }

        }
        if (target.tag == "Border")
        {
            Destroy(gameObject);
        }


    }
}
