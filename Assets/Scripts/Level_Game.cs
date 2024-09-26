using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level_Game : MonoBehaviour
{
    public TextMeshProUGUI leveltext;
    private void Update()
    {
        leveltext.text ="LEVEL " + PlayerPrefs.GetInt("level").ToString();
    }
}
