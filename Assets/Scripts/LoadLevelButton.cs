using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevelButton : MonoBehaviour
{
    public void LoadScene (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
