using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Home_InGame_BTN : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
