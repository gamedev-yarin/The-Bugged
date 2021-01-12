using UnityEngine;

/*
 * This component moves an object from the start point to the end point at a given speed.
 */

public class boxMoverLevel1 : MonoBehaviour
{

    [SerializeField] GameObject start;
    [SerializeField] GameObject end;
    [SerializeField] float speed = 5f;

    [SerializeField] Vector3 startPos;
    [SerializeField] Vector3 endPos;
    [SerializeField] bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        startPos = start.transform.position;
        endPos = end.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mover = new Vector3(speed * Time.deltaTime, 0, 0);
        if (flag) transform.position += mover;
        else transform.position -= mover;
        if (transform.position.x <= startPos.x) flag = true;
        if (transform.position.x >= endPos.x) flag = false;
    }
}