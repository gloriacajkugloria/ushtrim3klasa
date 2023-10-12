using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider other)
    {
        //ne do te ndryshojme pozicionin e lojtarit
        other.transform.position = teleportPoint.position;
    }
}

