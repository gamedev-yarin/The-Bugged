using UnityEngine;

/**
 * This component rotates its object according to the mouse movement in the Y axis, in a given rotation speed.
 */
public class LookY : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 1f;
    [SerializeField] private float test = 1f;
    [SerializeField] private Vector3 test1;

    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");
        //Debug.Log("mouse y = " + _mouseY);
        Vector3 rotation = transform.localEulerAngles;
        test1 = rotation;
        rotation.x -= _mouseY * _speedRotation;
        test = rotation.x;
        if (rotation.x > 270 || rotation.x < 90) transform.localEulerAngles = rotation;
    }
}
