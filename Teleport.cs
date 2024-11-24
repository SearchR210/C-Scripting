using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform TeleportPoint;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = TeleportPoint.position;
    }
}
