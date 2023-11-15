using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfTheBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -14.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);              
        }
        
    }
}
