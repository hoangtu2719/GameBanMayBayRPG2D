using System.Collections;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed;
    private Rigidbody2D myBody;
    [SerializeField]
    private GameObject bullet;
    private GamePlay gameController;
    [SerializeField]
    private GameObject hieuung;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D> ();
        gameController = GetComponent<GamePlay>();
    }

    void Start()
    {
        StartCoroutine(EnemyShoot());
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -enemySpeed);
    }
    IEnumerator EnemyShoot()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        Vector3 temp = transform.position;
        temp.y -= 0.5f;
        Instantiate(bullet, temp, Quaternion.identity);

        StartCoroutine(EnemyShoot());
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            if (GamePlay.instance != null)
            {
                GamePlay.instance.setlive(-1);
                GamePlay.instance.setbullet(-1);
                Destroy(gameObject);
                // hàm hiệu ứng  nổ
                Instantiate(hieuung, target.transform.position, Quaternion.identity);
            }    
            // Nếu điểm nhỏ hơn 0 thì Hủy game và show Panel
            if (GamePlay.instance.live < 0)
            {
                Destroy(target.gameObject);
                GamePlay.instance.PlaneDiedShowPanel(); // ke thua lop gamecontrolplay và gọi hàm
            }
        }
        if (target.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
  

}
