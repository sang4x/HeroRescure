using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ID_Level : MonoBehaviour
{
    public float levelNext;
    private void Awake()
    {
        levelNext = PlayerPrefs.GetInt("level") + 1;
    }
}
