using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    float damge = 10;// damge cua layer
    public float speed;
    private Rigidbody2D myBody;
    [SerializeField]
    private GameObject hieuung;
    /*private int point = 1;*/
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, speed);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        // Xét va chạm với máy bay địch
        if (target.tag == "Enemy")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
 
        }
        //Xét va chạm với thiên thạch lớn
        if (target.tag == "Meteorite")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        if (target.tag == "MeteoriteGrey")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        // Xét va chạm với thiên thạch nhỏ
        if (target.tag == "Meteoritesmall")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        // Xét va chạm với máy bay đỏ
        if (target.tag == "EnemyOrange")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        if (target.tag == "EnemyBlue")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        if (target.tag == "EnemyRed")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        if (target.tag == "Rocket")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        if (target.tag == "EnemyBom")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);
        }
        // Xét va chạm giữa đạn và Border
        if (target.tag == "Border")
        {
            Destroy(gameObject);
        }
        // Viết hàm trừ điểm con boss 
        // Nếu viên đạn va chạm tag boss thì thằng value của boss bị trừ 1 value
        if(target.tag == "Boss")
        {
            Boss.instance.beLastHealth(damge);
            Instantiate(hieuung, target.transform.position, Quaternion.identity);
            Destroy(gameObject);
            int point = 10;
            PlayerPrefs.SetInt("point", PlayerPrefs.GetInt("point") + point);   
        }
    }

}
