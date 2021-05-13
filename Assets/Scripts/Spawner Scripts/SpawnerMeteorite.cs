using System.Collections;
using UnityEngine;

public class SpawnerMeteorite : MonoBehaviour
{
    [SerializeField]
    private GameObject Meteorite;
    private BoxCollider2D box;
    [SerializeField]
    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        StartCoroutine(SpawnerMete());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnerMete()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
        Instantiate(Meteorite, temp,Quaternion.identity);//  Quaternion.identity(Xoay)

        StartCoroutine(SpawnerMete());
    }
    
}
