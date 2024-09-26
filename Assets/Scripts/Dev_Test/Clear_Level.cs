using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_Level : MonoBehaviour
{
    public void clear_LV()
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
