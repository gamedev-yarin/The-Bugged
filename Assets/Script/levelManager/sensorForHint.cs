using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorForHint : MonoBehaviour
{
    [SerializeField] string PlayerTag;

    public bool PlayerHitAensor = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == PlayerTag)
        {
            PlayerHitAensor = true;
        }
    }
}
