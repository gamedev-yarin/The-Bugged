using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script initializes the position of the object when it falls below the y-axis at a given number.
 */

public class resetBox : MonoBehaviour
{

    [SerializeField] float boundary = -1f;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < boundary) transform.position = startPos;
    }
}
