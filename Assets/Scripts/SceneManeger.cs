using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene(1);
    }
    public void SceneExit()
    {
        SceneManager.LoadScene(0);
    }
}
