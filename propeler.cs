using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelerMovement : MonoBehaviour
{
    public float speed = 100.0f;
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}