using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daily_Manager : MonoBehaviour
{
    public void CoinDailyReward(int coin)
    {
        PlayerPrefs.SetInt("coin",coin);
    }
}
