using UnityEngine;

public class Liveplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedlive;
    public int livepay;
    private Rigidbody2D mybody;
    void Start()
    {

    }
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        livepay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(0f, -speedlive);
       /* transform.Rotate(0, 3, 0);*/
    }

    void OnTriggerEnter2D(Collider2D targe)
    {
        if( targe.tag == "Player")
        {
            livepay += 1;
            if(GamePlay.instance !=null)
            {
                GamePlay.instance.setlive(livepay);
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
