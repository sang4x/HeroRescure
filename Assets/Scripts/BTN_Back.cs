using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTN_Back : MonoBehaviour
{
    private bool nullBackTaget = false;
    private bool nullBackOff = false;
    public List<GameObject> back_Off;
    public List<GameObject> back_Taget;

    public void Update()
    {
            for (int i = 0; i < back_Taget.Count; i++)
         {
                if (back_Taget[i] == null)
            {
                nullBackTaget = true;
            }
            else
            {
                nullBackTaget = false;
            }
         }
        for (int i = 0; i < back_Off.Count; i++)
        {
            if (back_Off[i] == null)
            {
                nullBackOff = true;
            }
            else
            {
                nullBackOff = false;
            }
        }
    }
    public void BackEvent()
    {
        if (back_Off.Count > 0 && nullBackOff == false)
        {
            for (int i = 0; i < back_Off.Count; i++)
            {
                back_Off[i].SetActive(false);
            }
        }
        if (back_Taget.Count >0 && nullBackTaget == false)
        {
            for (int i = 0; i < back_Taget.Count; i++)
            {
                back_Taget[i].SetActive(true);
            }
        }
    }
}
