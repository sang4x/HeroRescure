using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading_Save : MonoBehaviour
{
    private int coin = 10000;
    private int levelstart = 1;
    private void Awake()
    {
        PlayerPrefs.SetInt("haveskin5", 0);
        PlayerPrefs.SetInt("haveskin2", 0);
        PlayerPrefs.SetInt("haveskin1", 0);
        PlayerPrefs.SetString("skin", "1");
        PlayerPrefs.SetString("sword", "Kiem");
        PlayerPrefs.SetInt("haveskin3", 0);
        PlayerPrefs.SetInt("haveskin4", 0);
        PlayerPrefs.SetInt("coin", 0);
        PlayerPrefs.SetInt("level", 1);
    }
}
