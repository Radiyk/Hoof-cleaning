using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polySurfacelife : MonoBehaviour
{
    private float lifetime = 2;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

}
