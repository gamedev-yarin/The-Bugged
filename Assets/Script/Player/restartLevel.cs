using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * This script gives the player the option to restart the level.
 */

public class restartLevel : MonoBehaviour
{
    [SerializeField] string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(sceneName);
    }
}
