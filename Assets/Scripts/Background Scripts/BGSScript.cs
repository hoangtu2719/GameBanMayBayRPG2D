using UnityEngine;

public class BGSScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var worldHeight = Camera.main.orthographicSize * 2f;
        var worldWitdh = worldHeight * Screen.width / Screen.height;
        transform.localScale = new Vector3(worldWitdh, worldHeight, 0f);
        }


}
