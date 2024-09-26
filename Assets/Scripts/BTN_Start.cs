using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTN_Start : MonoBehaviour
{
    public void PlayStartBTN()
    {
        SceneManager.LoadSceneAsync("Black_Load");
    }
}
