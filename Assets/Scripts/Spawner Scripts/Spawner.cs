using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject enemy, enemy1,enemy2,enemy3,Live,Bullet;
    private BoxCollider2D box;
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();

    }
    void Start()
    {
        StartCoroutine(SpawnerEnemy());
        StartCoroutine(SpawnerEnemy1());
        StartCoroutine(SpawnerEnemy2());
        StartCoroutine(SpawnerEnemy3());
        StartCoroutine(LivePlane());
        StartCoroutine(BulletPlane());
    }
    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnerEnemy()
    {
        yield return new WaitForSeconds (Random.Range (1f, 3f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX,maxX);
        Instantiate (enemy, temp, Quaternion.identity );

        StartCoroutine(SpawnerEnemy());
    }
    IEnumerator SpawnerEnemy1()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp1 = transform.position;
        temp1.x = Random.Range(minX, maxX);
        Instantiate(enemy1, temp1, Quaternion.identity);

        StartCoroutine(SpawnerEnemy1());
    }
    IEnumerator SpawnerEnemy2()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp2 = transform.position;
        temp2.x = Random.Range(minX, maxX);
        Instantiate(enemy2, temp2, Quaternion.identity);

        StartCoroutine(SpawnerEnemy2());
    }
    IEnumerator SpawnerEnemy3()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp3 = transform.position;
        temp3.x = Random.Range(minX, maxX);
        Instantiate(enemy3, temp3, Quaternion.identity);

        StartCoroutine(SpawnerEnemy3());
    }
    IEnumerator LivePlane()
    {
        yield return new WaitForSeconds(Random.Range(10f, 20f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp4 = transform.position;
        temp4.x = Random.Range(minX, maxX);
        Instantiate(Live, temp4, Quaternion.identity);

        StartCoroutine(LivePlane());
    }
    IEnumerator BulletPlane()
    {
        yield return new WaitForSeconds(Random.Range(18f, 30f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp5 = transform.position;
        temp5.x = Random.Range(minX, maxX);
        Instantiate(Bullet, temp5, Quaternion.identity);

        StartCoroutine(BulletPlane());
    }
}
