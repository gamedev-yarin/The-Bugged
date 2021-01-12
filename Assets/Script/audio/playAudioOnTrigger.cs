using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioOnTrigger : MonoBehaviour
{
    [SerializeField] string tagToActivat;
    [SerializeField] string audioToPlay;

    [SerializeField] bool alreadyHappened = false;

    //private bool alreadyHappened = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!alreadyHappened && other.tag == tagToActivat)
        {
            alreadyHappened = true;
            AudioManager Audiomanager = FindObjectOfType<AudioManager>();
            Audiomanager.Play(audioToPlay);
        }
    }
}
