using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    [SerializeField] GameObject animatorObject;
    [SerializeField] string triggerName;
    [SerializeField] string playerTag;

    private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == playerTag)
        {
            animator.SetTrigger(triggerName);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = animatorObject.GetComponent<Animator>();
    }
}
