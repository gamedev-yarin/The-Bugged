using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This component make the object interactable with the player object.
 */

public class interactable : MonoBehaviour
{
    [SerializeField] float redius = 2f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, redius);
    }

    public float getRedius()
    {
        return redius;
    }
}
