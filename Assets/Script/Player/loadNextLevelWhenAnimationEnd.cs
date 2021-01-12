using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadNextLevelWhenAnimationEnd : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void onAnimationComplete()
    {
        SceneManager.LoadScene(sceneName);
    }
}
