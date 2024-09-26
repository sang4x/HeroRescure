using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Awake_Loading : MonoBehaviour
{
    public TextMeshProUGUI loadingText;
    public GameObject gameLoading;
    void Start()
    {

        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync("MainLoad");
        gameLoading.SetActive(true);
        while (!gameLevel.isDone)
        {
            loadingText.text = "Loading " + (Mathf.Clamp01(gameLevel.progress)*100) + "%";
            yield return new WaitForFixedUpdate();
        }
    }
}
