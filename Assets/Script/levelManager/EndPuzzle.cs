using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPuzzle : MonoBehaviour
{

    [SerializeField] GameObject sensor1;
    [SerializeField] GameObject sensor2;
    [SerializeField] GameObject sensor3;
    [SerializeField] GameObject sensor4;
    [SerializeField] GameObject sensor5;

    [SerializeField] [Range(0f, 3f)] float timeToCheckIfThePuzzleSolved = 1f;

    [SerializeField] public GameObject[] toDeletWhenPuzzleOver;

    private bool PuzzleSolved = false;
    void Start()
    {
        StartCoroutine(CheckPuzzle());
    }

    public IEnumerator CheckPuzzle()
    {
        while (!PuzzleSolved)
        {
            if (sensor1.GetComponent<sensorForPuzzle>().trigger &&
                sensor2.GetComponent<sensorForPuzzle>().trigger &&
                sensor3.GetComponent<sensorForPuzzle>().trigger &&
                sensor4.GetComponent<sensorForPuzzle>().trigger &&
                sensor5.GetComponent<sensorForPuzzle>().trigger) PuzzleSolved = true;
            else yield return new WaitForSeconds(timeToCheckIfThePuzzleSolved);
        }
    }


    void Update()
    {
        if (PuzzleSolved)
        {
            foreach(GameObject g in toDeletWhenPuzzleOver)
            {
                g.SetActive(false);
            }
        }
    }
}
