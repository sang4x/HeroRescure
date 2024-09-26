using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Controller : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Collider2D coll2D;
    public Transform playerPos;
    public Player_Controller playerController;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        coll2D = GetComponent<Collider2D>();
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
        playerController = GameObject.Find("Player").GetComponent<Player_Controller>();
    }
    private void Update()
    {
        if (playerController.isWin == true)
        {
            rb2D.simulated = false;
            rb2D.gravityScale = 0;
            coll2D.isTrigger = true;
            transform.position = Vector3.Lerp(transform.position,playerPos.position,2*Time.deltaTime);
            if (transform.position == playerPos.position)
            {
                Destroy(gameObject);
            }
        }
    }
}
