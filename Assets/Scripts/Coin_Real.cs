using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin_Real : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private void Update()
    {
        coinText.text =""+PlayerPrefs.GetInt("coin");
    }
}
