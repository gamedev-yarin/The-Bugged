using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manager : MonoBehaviour
{
    [SerializeField] string AudioManagerName;
    [SerializeField] string Audio;
    [SerializeField] [Range(0f, 1f)] float timeToCheckIfTheSoundIsPlaying = .1f;

    [SerializeField] string hint;
    [SerializeField] float timeToSolveThePuzzle = 180f;
    [SerializeField] GameObject sensorToDisableHint;




    void Start()
    {
        StartCoroutine(level3());
    }

    public IEnumerator level3()
    {
        AudioManager Audiomanager = GameObject.Find(AudioManagerName).GetComponent<AudioManager>();
        Audiomanager.Play(Audio);
        while (Audiomanager.isPlaying(Audio))
        {
            yield return new WaitForSeconds(timeToCheckIfTheSoundIsPlaying);
        }
        yield return new WaitForSeconds(timeToSolveThePuzzle);
        if (!sensorToDisableHint.GetComponent<sensorForHint>().PlayerHitAensor) Audiomanager.Play(hint);

    }
}
