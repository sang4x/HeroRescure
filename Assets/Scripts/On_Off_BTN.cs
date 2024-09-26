using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off_BTN : MonoBehaviour
{
    public GameObject On_BTN;
    public GameObject Off_BTN;
    private void Awake()
    {
        On_BTN.SetActive(true);
        Off_BTN.SetActive(false);
    }
    public void OnGameObject()
    {
        On_BTN.SetActive(true);
        Off_BTN.SetActive(false);
    }
    public void OffGameObject()
    {
        On_BTN.SetActive(false);
        Off_BTN.SetActive(true);
    }
}
