using UnityEngine;

public class RocketBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D myBody;

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -speed);
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
    void OnTriggerExit2D(Collider2D target)
    {
        /// nó đây
    }

}
