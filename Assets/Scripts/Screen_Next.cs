using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen_Next : MonoBehaviour
{
    public Camera cam;
    public Transform trackPlayer;
    public Transform playerPos;
    public bool IsTap;
    public GameObject winGame;
    public GameObject loseGame;
    public Player_Controller playerCtrl;
    private Vector3 startTrack;
    private float timefix = 1f;
    private void Awake()
    {
        winGame.SetActive(false);
        loseGame.SetActive(false);
        IsTap = false;
        playerCtrl = GameObject.Find("Player").GetComponent<Player_Controller>();
    }
    public void Tap()
    {
        IsTap = true;
    }
    private void Update()
    {
        timefix -= Time.deltaTime;
        if (timefix <=0 && trackPlayer.position != startTrack)
        {
            timefix = 1f;
            startTrack = trackPlayer.position;
        }

        if (playerCtrl.isWin == true && playerCtrl.isLose == true)
        {
            playerCtrl.isWin = true;
            playerCtrl.isLose = false;
        }
        if (playerCtrl.isWin == true)
        {
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - 1.5f * Time.deltaTime, 3, 10);
            trackPlayer.position = Vector2.Lerp(trackPlayer.position,playerPos.position, 1.5f*Time.deltaTime);
            if (trackPlayer.position == startTrack )
            {
                winGame.SetActive(true);
            }
        }
        else if (playerCtrl.isLose == true)
        {
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - 1.5f * Time.deltaTime, 3, 10);
            trackPlayer.position = Vector2.Lerp(trackPlayer.position,playerPos.position,1f*Time.deltaTime);
            if (trackPlayer.position == startTrack)
            {
                loseGame.SetActive(true);
            }
        }
    }

}
