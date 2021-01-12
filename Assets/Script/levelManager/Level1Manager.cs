using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    [SerializeField] string AudioManagerName;
    [SerializeField] string Audio;
    [SerializeField] [Range(0f, 1f)] float timeToCheckIfTheSoundIsPlaying = .1f;

    [SerializeField] string hintAudio;
    [SerializeField] GameObject sensorToDisableHint1;
    [SerializeField] float timeToSolveTheFirstPuzzle = 60f;

    [SerializeField] GameObject hintText;
    [SerializeField] GameObject sensorToDisableHint2;
    [SerializeField] float timeToSolveTheSecondPuzzle = 60f;


    void Start()
    {
        StartCoroutine(level1());
    }

    public IEnumerator level1()
    {
        hintText.SetActive(false);
        AudioManager Audiomanager = GameObject.Find(AudioManagerName).GetComponent<AudioManager>();
        Audiomanager.Play(Audio);
        while (Audiomanager.isPlaying(Audio))
        {
            yield return new WaitForSeconds(timeToCheckIfTheSoundIsPlaying);
        }
        yield return new WaitForSeconds(timeToSolveTheFirstPuzzle);
        if (!sensorToDisableHint1.GetComponent<sensorForHint>().PlayerHitAensor) Audiomanager.Play(hintAudio);
        {
            yield return new WaitForSeconds(timeToCheckIfTheSoundIsPlaying);
        }
        yield return new WaitForSeconds(timeToSolveTheSecondPuzzle);
        if (!sensorToDisableHint2.GetComponent<sensorForHint>().PlayerHitAensor) hintText.SetActive(true);

    }
}
