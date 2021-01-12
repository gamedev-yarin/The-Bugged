using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{
    [SerializeField] string AudioManagerName;

    [SerializeField] GameObject animatorObject;
    [SerializeField] string triggerName;
    [SerializeField] string playerTag;

    [SerializeField] string triggerwine;
    [SerializeField] string triggerlose;

    [SerializeField] string win;
    [SerializeField] string lose;

    [SerializeField] GameObject palyer;

    [SerializeField] string winAudio;

    private Animator animator;
    private bool wine;
    AudioManager Audiomanager;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == playerTag)
        {
            if (wine)
            {
                animator.SetTrigger(triggerwine);
                Audiomanager.Play(win);
                Audiomanager.Play(winAudio);
                Audiomanager.stop("theme");
                

            }
            else {
                animator.SetTrigger(triggerlose);
                Audiomanager.Play(lose);
            }
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = animatorObject.GetComponent<Animator>();
        Audiomanager = GameObject.Find(AudioManagerName).GetComponent<AudioManager>();

    }

    private void Update()
    {
        if (palyer.GetComponent<pointSystem>().point == 1)
        {
            wine = true;
        }
    }
}