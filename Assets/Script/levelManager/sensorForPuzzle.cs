using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorForPuzzle : MonoBehaviour
{
    [SerializeField] string Tag;

    public bool trigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tag)
        {
            trigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == Tag)
        {
            trigger = false;
        }
    }
}
