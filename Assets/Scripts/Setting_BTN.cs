using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_BTN : MonoBehaviour
{
    public GameObject[] play;
    public GameObject[] hide_;
    public GameObject setting;
    public void PlaySetting()
    {
        if (setting != null)
        {
            setting.SetActive(true);
        }
    }
    public void Play_BTN_Hide()
    {
        if (hide_!= null)
        {
            for (int i = 0; i < hide_.Length; i++)
            {
                hide_[i].SetActive(false);
            }
        }
        if (play!= null)
        {
            for (int i = 0; i < play.Length; i++)
            {
                play[i].SetActive(true);
            }
        }
    }
}
