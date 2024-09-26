using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Black_Loading : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }
    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(PlayerPrefs.GetInt("level")+1);
        while (!gameLevel.isDone)
        {
            yield return new WaitForFixedUpdate();
        }
    }
}
