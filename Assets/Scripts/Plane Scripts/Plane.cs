using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plane : MonoBehaviour
{
    // Start is called before the first frame update
    public float planeSpeed;
    private Rigidbody2D myBody;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject bullet2;
    [SerializeField]
    private GameObject bullet3;
    private bool canShoot = true;
    /*[SerializeField]
    public Joystick joystick;*/
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlaneMovement();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (canShoot == true)
            {
                if (GamePlay.instance.bulleter >= 1)
                {
                    StartCoroutine(Shoot2());
                    
                }
                else
                {
                    StartCoroutine(Shoot());
                }    
            }
        }
    }
    void PlaneMovement()
    {
       /* float xAsis = joystick.Horizontal * planeSpeed;
        float yAsis = joystick.Vertical * planeSpeed;
        myBody.velocity = new Vector2(xAsis, yAsis);*/
        float xAsis = Input.GetAxisRaw("Horizontal") * planeSpeed;
        float yAsis = Input.GetAxisRaw("Vertical") * planeSpeed;
        myBody.velocity = new Vector2(xAsis, yAsis);
    }
/*    public void Shooting()
    {
        if (canShoot)
        {
            StartCoroutine(Shoot());
        }
    }*/
    IEnumerator Shoot()
    {
        canShoot = false;
        // lấy vị trí của máy bay sau đó cộng lên rồi cho viên đạn bắn tại vị trí đó
        Vector3 temp = transform.position;
        temp.y += 0.6f;
        //truyen vào vật cần xuất ra, vị trí, và không cho vật đó xoay
        Instantiate(bullet, temp, Quaternion.identity);//Sinh ra viên đạn
        yield return new WaitForSeconds(0.2f); // 0.2s bắn ra đạn.
        canShoot = true;

    }
    IEnumerator Shoot2()
    {
        canShoot = false;
        // lấy vị trí của máy bay sau đó cộng lên rồi cho viên đạn bắn tại vị tí
        // đó
        Vector3 temp = transform.position;
        temp.x += 0.5f;
        Vector3 temp2 = transform.position;
        temp2.x -= 0.5f;
        Vector3 temp3 = transform.position;
        temp3.y += 0.6f;
        //truyen vào vật cần xuất ra, vị trí, và không cho vật đó xoay
        Instantiate(bullet, temp, Quaternion.identity); // sinh ra ven dan
        Instantiate(bullet2, temp2, Quaternion.identity);
        Instantiate(bullet3, temp3, Quaternion.identity);
        yield return new WaitForSeconds(0.2f); // 1s thi ban ra vien dan
        canShoot = true;
    }
  /*  IEnumerator Shoot3()
    {
        canShoot = false;
        // lấy vị trí của máy bay sau đó cộng lên rồi cho viên đạn bắn tại vị tí
        // đó
        Vector3 temp = transform.position;
        temp.x += 0.5f;
        Vector3 temp2 = transform.position;
        temp2.x -= 0.5f;
        Vector3 temp3 = transform.position;
        temp3.y += 0.6f;
        //truyen vào vật cần xuất ra, vị trí, và không cho vật đó xoay
        Instantiate(bullet, temp, Quaternion.identity); // sinh ra ven dan
        Instantiate(bullet2, temp2, Quaternion.identity);
        Instantiate(bullet3, temp3, Quaternion.identity);
        yield return new WaitForSeconds(1f); // 1s thi ban ra vien dan
        canShoot = true;
    }*/
}