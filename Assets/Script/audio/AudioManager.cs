using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

    [SerializeField] public String theme;
    [SerializeField] public Sound[] sounds;

    public static AudioManager instance;


    void Awake()
    {
        if (instance == null) instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }

    public bool isPlaying(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        return s.source.isPlaying;
    }

    public void nusicVol(float vol)
    {
        foreach (Sound s in sounds)
        {
            if (s.music) s.source.volume = vol;
        }
    }

    public void effectsVol(float vol)
    {
        foreach (Sound s in sounds)
        {
            if (!s.music) s.source.volume = vol;
        }
    }

    private void Start()
    {
        Play(theme);
    }
}
