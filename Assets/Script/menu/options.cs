using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour
{
    public void musicVolume(float volume)
    {
        AudioManager Audiomanager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        Audiomanager.nusicVol(volume);
    }

    public void effectsVolume(float volume)
    {
        AudioManager Audiomanager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        Audiomanager.effectsVol(volume);
    }
}
