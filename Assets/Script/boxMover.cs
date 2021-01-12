using UnityEngine;

/*
 * This component moves an object from the start point to the end point at a given speed.
 */

public class boxMover : MonoBehaviour
{

    [SerializeField] GameObject start;
    [SerializeField] GameObject end;
    [SerializeField] float speed = 5f;

    [SerializeField] bool startFromEnd = true;

    [SerializeField] GameObject pauseObject;

    Vector3 startPos;
    Vector3 endPos;


    void Start()
    {
        startPos = start.transform.position;
        endPos = end.transform.position;
        if (startFromEnd)
        {
            Vector3 tempPos = transform.position;
            tempPos.x = endPos.x;
            transform.position = tempPos;
        }
        else
        {
            Vector3 tempPos = transform.position;
            tempPos.x = startPos.x;
            transform.position = tempPos;
        }

    }

    void Update()
    {
        if (pauseObject != null) {
            PauseGame pg = pauseObject.GetComponent<PauseGame>();
            if (pg.gamePause) return;
            else
            {
                Mover();
            }
        }
        else 
        {
            Mover();
        }

    }


    private void Mover()
    {
        Vector3 mover = new Vector3(speed * Time.deltaTime, 0, 0);
        if (startFromEnd) transform.position += mover;
        else transform.position -= mover;
        if (transform.position.x <= endPos.x) startFromEnd = true;
        if (transform.position.x >= startPos.x) startFromEnd = false;
    }
}
