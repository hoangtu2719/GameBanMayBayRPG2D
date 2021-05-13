using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationBom : MonoBehaviour
{
    [SerializeField]
    private float playtime;

    void Start()
    {
        Destroy(gameObject, playtime);
    }
}
