using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour
{
    [SerializeField] string AudioManagerName;
    [SerializeField] string Audio;
    [SerializeField] [Range(0f, 1f)] float timeToCheckIfTheSoundIsPlaying = .1f;

    [SerializeField] GameObject Hint1;
    [SerializeField] GameObject sensorToDisableHint1;
    [SerializeField] float timeToSolveTheFirstPuzzle = 60f;

    [SerializeField] GameObject Hint2;
    [SerializeField] GameObject sensorToDisableHint2;
    [SerializeField] float timeToSolveTheSecondPuzzle = 60f;


    void Start()
    {
        StartCoroutine(level2());
    }

    public IEnumerator level2()
    {
        Hint1.SetActive(false);
        Hint2.SetActive(false);
        AudioManager Audiomanager = GameObject.Find(AudioManagerName).GetComponent<AudioManager>();
        Audiomanager.Play(Audio);
        while (Audiomanager.isPlaying(Audio))
        {
            yield return new WaitForSeconds(timeToCheckIfTheSoundIsPlaying);
        }
        yield return new WaitForSeconds(timeToSolveTheFirstPuzzle);
        if (!sensorToDisableHint1.GetComponent<sensorForHint>().PlayerHitAensor) Hint1.SetActive(true);

        yield return new WaitForSeconds(timeToSolveTheSecondPuzzle);
        if (!sensorToDisableHint2.GetComponent<sensorForHint>().PlayerHitAensor) Hint2.SetActive(true);

    }
}
