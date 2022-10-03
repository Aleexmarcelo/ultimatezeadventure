using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    private int prevSceneToLoad;

    private void Start()
    {
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider collision)
    {
        SceneManager.LoadScene(prevSceneToLoad);
    }
}

