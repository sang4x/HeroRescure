using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload_Level_BTN : MonoBehaviour
{
    public void ReLoad()
    {
        SceneManager.LoadScene("Black_Load");
    }
}
