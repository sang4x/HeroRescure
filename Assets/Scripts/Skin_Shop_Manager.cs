using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using UnityEngine.UI;

public class Skin_Shop_Manager : MonoBehaviour
{
    public SkeletonGraphic skHero;
    public string dd;
    public GameObject[] defaut;
    public GameObject[] dragon;
    public GameObject[] holy;
    public GameObject[] king;
    public GameObject[] hercules;
    public GameObject[] superman;

    private void Start()
    {
        skHero = GetComponent<SkeletonGraphic>();
        if ( PlayerPrefs.GetInt("haveskin1") == 1)
        {
            for (int i = 0; i < dragon.Length; i++)
            {
                dragon[i].SetActive(false);
            }
        }
        if ( PlayerPrefs.GetInt("haveskin2") == 1)
        {
            for (int i = 0; i < holy.Length; i++)
            {
                holy[i].SetActive(false);
            }
        }
        if ( PlayerPrefs.GetInt("haveskin3") == 1)
        {
            for (int i = 0; i < king.Length; i++)
            {
                king[i].SetActive(false);
            }
        }
        if ( PlayerPrefs.GetInt("haveskin4") == 1)
        {
            for (int i = 0; i < hercules.Length; i++)
            {
                hercules[i].SetActive(false);
            }
        }
        if ( PlayerPrefs.GetInt("haveskin5") == 1)
        {
            for (int i = 0; i < superman.Length; i++)
            {
                superman[i].SetActive(false);
            }
        }
    }
    public void Defaut()
    {
        for (int i = 0; i < defaut.Length; i++)
        {
            defaut[i].SetActive(false);
        }
        PlayerPrefs.SetString("skin", "1");
        PlayerPrefs.SetString("sword", "Kiem");
        LoadSkin();
    }
    public void DragonSkin1(int gold)
    {
        LoadSkin();
        if (PlayerPrefs.GetInt("coin") - gold >=0 && PlayerPrefs.GetInt("haveskin1") == 0)
        {
            for (int i = 0; i < dragon.Length; i++)
            {
                dragon[i].SetActive(false);
            }
            PlayerPrefs.SetInt("haveskin1", 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - gold);
        }
        if (PlayerPrefs.GetInt("haveskin1")==1)
        {
            LoadSkin();
            for (int i = 0; i < dragon.Length; i++)
            {
                dragon[i].SetActive(false);
            }
            PlayerPrefs.SetString("skin", "dragon Knight/dragon knight");
            PlayerPrefs.SetString("sword", "dragon Knight/kiem dragon knight");
        }
    }
    public void HolySkin2(int gold)
    {
        LoadSkin();
        if (PlayerPrefs.GetInt("coin") - gold >= 0&& PlayerPrefs.GetInt("haveskin2") == 0)
        {
            for (int i = 0; i < holy.Length; i++)
            {
                holy[i].SetActive(false);
            }
            PlayerPrefs.SetInt("haveskin2", 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - gold);
        }
        if (PlayerPrefs.GetInt("haveskin2") == 1)
        {
            for (int i = 0; i < holy.Length; i++)
            {
                holy[i].SetActive(false);
            }
            PlayerPrefs.SetString("skin", "Holy/holy");
            PlayerPrefs.SetString("sword", "Holy/kiem holy");
        }
    }
    public  void KingSkin3(int gold)
    {
        LoadSkin();
        if (PlayerPrefs.GetInt("coin") - gold >= 0&&PlayerPrefs.GetInt("haveskin3") == 0)
        {
            PlayerPrefs.SetInt("haveskin3", 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - gold);
            for (int i = 0; i < king.Length; i++)
            {
                king[i].SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("haveskin3") == 1)
        {
            for (int i = 0; i < king.Length; i++)
            {
                king[i].SetActive(false);
            }
            PlayerPrefs.SetString("skin", "Athur/Athur");
            PlayerPrefs.SetString("sword", "Athur/kiem Athur");
        }
    }
    public void Hercules4(int gold)
    {
        LoadSkin();
        if (PlayerPrefs.GetInt("coin") - gold >= 0&& PlayerPrefs.GetInt("haveskin4") == 0)
        {
            for (int i = 0; i < hercules.Length; i++)
            {
                hercules[i].SetActive(false);
            }
            PlayerPrefs.SetInt("haveskin4", 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - gold);
        }
        if (PlayerPrefs.GetInt("haveskin4") == 1)
        {
            for (int i = 0; i < hercules.Length; i++)
            {
                hercules[i].SetActive(false);
            }
            PlayerPrefs.SetString("skin", "Hercules/hercules");
            PlayerPrefs.SetString("sword", "Hecrcules/kiem hercules");
        }
    }
    public void SupermanSkin5(int gold)
    {
        LoadSkin();
        if (PlayerPrefs.GetInt("coin") - gold >= 0&& PlayerPrefs.GetInt("haveskin5") == 0)
        {
            for (int i = 0; i < superman.Length; i++)
            {
                superman[i].SetActive(false);
            }
            PlayerPrefs.SetInt("haveskin5", 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - gold);
        }
        if (PlayerPrefs.GetInt("haveskin5")==1)
        {
            for (int i = 0; i < superman.Length; i++)
            {
                superman[i].SetActive(false);
            }
            PlayerPrefs.SetString("skin", "Superman/superman");
            PlayerPrefs.SetString("sword", "Superman/kiem superman");
        }
    }
    public void LoadSkin()
    {
        skHero.LateUpdate();
    }
    private void Update()
    {
        skHero.Skeleton.SetSkin("1");
        dd = PlayerPrefs.GetString("skin");
    }
}
