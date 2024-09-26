using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Color newColor;
    public Image targetImage;
    public void Awake()
    {
        if (targetImage != null)
        {
            targetImage.color = newColor; 
        }

    }
}
