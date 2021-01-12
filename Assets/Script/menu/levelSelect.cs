using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    public void level0()
    {
        SceneManager.LoadScene("level-0");
    }
    public void level1()
    {
        SceneManager.LoadScene("level-1");
    }
    public void level2()
    {
        SceneManager.LoadScene("level-2");
    }
    public void level3()
    {
        SceneManager.LoadScene("level-3");
    }
}
