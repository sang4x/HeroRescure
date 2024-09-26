using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool IsSpawnCoin = true;
    public List<GameObject> coin_Spawn;
    public Transform coin_Pos;
    public float level_Game;
    public string level_Search;
    private void Awake()
    {
        
        if (GameObject.Find("Coin_Spawn_Pos") != null)
        {
            coin_Pos = GameObject.Find("Coin_Spawn_Pos").GetComponent<Transform>();
        }
        if (coin_Pos != null && IsSpawnCoin == true)
        {
            for (int i = 1; i< 20;i++)
            {
                SpawnObject();
            }
        }
    }
    public void SpawnObject()
    {
        if (coin_Spawn.Count > 0)
        {
            int index = Random.Range(0, coin_Spawn.Count);
            Instantiate(coin_Spawn[index], coin_Pos.position, transform.rotation);
        }
    }
}
