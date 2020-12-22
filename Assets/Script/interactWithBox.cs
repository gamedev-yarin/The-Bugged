using UnityEngine;

/*
 * This component responsible to how the object interact with a box.
 */

public class interactWithBox : MonoBehaviour
{


    [SerializeField] GameObject interactablePosition;
    [SerializeField] int maxDistanceForRay = 100;

    interactable interact;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxDistanceForRay)) //if the ray hit
            {
                interact = hit.collider.GetComponent<interactable>();
                if(interact != null)
                {
                    hit.transform.position = interactablePosition.transform.position;
                }
            }
        }
    }
}
