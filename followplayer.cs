#Kodas skirtas tam, kad kamera sektu personaza 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // LateUpdate naudojamas po visų Update ciklų, tai tinka sekimo skriptams.
    void LateUpdate()
    {
        // Pakeiskite kameros poziciją taip, kad ji sekė žaidimo objektą.
        transform.position = player.transform.position + offset;
    }
}