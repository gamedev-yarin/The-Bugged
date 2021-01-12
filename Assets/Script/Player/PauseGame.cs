using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] GameObject animatorObject;
    [SerializeField] string triggerToPause;
    [SerializeField] string triggerToUnpause;

    private Animator animator;

    public bool gamePause = false;


    void Start()
    {
        animator = animatorObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gamePause)
            {
                animator.SetTrigger(triggerToUnpause);
                gamePause = false;
            }
            else
            {
                animator.SetTrigger(triggerToPause);
                gamePause = true;
            }
 
        }


    }
}
