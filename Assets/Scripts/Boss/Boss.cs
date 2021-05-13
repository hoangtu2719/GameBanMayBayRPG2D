using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;// máu mặc định của boss
    float currentHealth;
    [SerializeField]
    private Slider healthBar;
    public static Boss instance;
    [SerializeField]
    private GameObject bullet;
    public GameObject gun1;
    public GameObject gun2;
    private void Start()
    {
        instance = this;
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;// gán thanh máu bằng máu mặc định
        StartCoroutine(BossShoot());
    }
    //Test
  
    // Test
    private void Update()
    {

    }
    //Trừ đi máu dựa trên thông số vào là _damger
    public bool beLastHealth(float _damger)
    {
        //float expcurrentHealth = currentHealth - _damger;
        healthBar.value -= _damger;
        return true;
    }
    IEnumerator BossShoot()
    {
        yield return new WaitForSeconds(Random.Range(3f,5f));

        Instantiate(bullet, gun1.transform.position, Quaternion.identity);
        Instantiate(bullet, gun2.transform.position, Quaternion.identity);
        StartCoroutine(BossShoot());
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            if (GamePlay.instance != null)
            {
                GamePlay.instance.setlive(-1);
                GamePlay.instance.setbullet(-1);
                /*Destroy(gameObject);*//*
                // hàm hiệu ứng  nổ
*//*                Instantiate(hieuung, target.transform.position, Quaternion.identity);*/
            }
            // Nếu điểm nhỏ hơn 0 thì Hủy game và show Panel
            if (GamePlay.instance.live < 0)
            {
                Destroy(target.gameObject);
                GamePlay.instance.PlaneDiedShowPanel(); // ke thua lop gamecontrolplay và gọi hàm
            } 
        }
        if (healthBar.value <= 0)
        {
            Destroy(gameObject);
            GamePlay.instance.DoShowPanalWinGame();
            /*GamePlay.instance.GameWinShowPanel();*/
        }
    }
}
