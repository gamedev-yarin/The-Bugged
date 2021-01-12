using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0Manager : MonoBehaviour
{
    [SerializeField] string AudioManagerName;
    [SerializeField] GameObject text;
    [SerializeField] string AudioPart1;
    [SerializeField] string AudioPart2;
    [SerializeField] float timeToDisplayControllers = 3f;
    [SerializeField] [Range(0f, 1f)] float timeToCheckIfTheSoundIsPlaying = .1f;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject door;
    [SerializeField] float timeTolayPart3 = .5f;
    [SerializeField] string AudioPart3;

    void Start()
    {
        StartCoroutine(level0());
    }

    public IEnumerator level0()
    {
        door.gameObject.SetActive(false);
        wall.gameObject.SetActive(true);
        text.gameObject.SetActive(false);
        AudioManager Audiomanager = GameObject.Find(AudioManagerName).GetComponent<AudioManager>();
        Audiomanager.Play(AudioPart1);
        while (Audiomanager.isPlaying(AudioPart1))
        {
            yield return new WaitForSeconds(timeToCheckIfTheSoundIsPlaying);
        }
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(timeToDisplayControllers);
        text.gameObject.SetActive(false);
        Audiomanager.Play(AudioPart2);
        while (Audiomanager.isPlaying(AudioPart2))
        {
            yield return new WaitForSeconds(timeToCheckIfTheSoundIsPlaying);
        }
        door.gameObject.SetActive(true);
        wall.gameObject.SetActive(false);
        yield return new WaitForSeconds(timeTolayPart3);
        Audiomanager.Play(AudioPart3);
    }
}
