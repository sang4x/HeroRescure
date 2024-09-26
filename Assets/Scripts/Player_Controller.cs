using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class Player_Controller : MonoBehaviour
{
    public Screen_Next screenManager;
    public SkeletonAnimation skAnimation;
    public Auto_Pin auto;

    private Vector3 vector;
    private float timefix = 0.4f;
    public Vector2 Timef1;
    public Vector2 Timef2;
    private Vector2 transfix1;
    private Vector2 transfix2;

    public bool isSword=false;
    public bool isLose = false;
    public bool isWin=false;
    private Rigidbody2D rb2D;
    private Vector3 direction;
    public GameObject playRun;
    public bool isLeft=false;
    public float SPD = 0.05f;
    public bool IsMove;
    private int levelScore;
    public float TimeChangeAnim;
    private float timeChangeAnim;

    public ID_Level iD_Level;

    private void Awake()
    {
        screenManager = GameObject.Find("GameManager").GetComponent<Screen_Next>();
        if (playRun != null)
        {
            auto = playRun.GetComponent<Auto_Pin>();
        }
        rb2D = GetComponent<Rigidbody2D>();
        iD_Level = GameObject.Find("ID_Level").GetComponent<ID_Level>();
    }
    private void Start()
    {
        skAnimation.initialSkinName = PlayerPrefs.GetString("skin");
        ReloadSkeleton();
        skAnimation.state.SetAnimation(0, "idle", true);
        direction = Vector3.right;
    }
    private void FixedUpdate()
    {
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    public void ReloadSkeleton()
    {
        skAnimation.Initialize(true);
    }
    private void Update()
    {
        timeChangeAnim -= Time.deltaTime;
        if (isWin == true )
        {
            levelScore++;
            timeChangeAnim = TimeChangeAnim;
        }
        if (isWin == true && screenManager.IsTap == true)
        {
            PlayerPrefs.SetInt("level",levelScore= Mathf.Clamp(levelScore, (int)iD_Level.levelNext-1, (int)iD_Level.levelNext));
        }
        if (isWin == false && IsMove == true)
        {
            if (auto.runPLayer == true || auto == null)
            {
                if (isSword == true)
                {
                    skAnimation.state.SetAnimation(0, "run (kiem)", true);
                }
                else if (isSword == false)
                {
                    skAnimation.state.SetAnimation(0, "run", true);
                }
                vector = transform.localScale;
                vector = new Vector3(vector.x, vector.y * -1, vector.z * -1);
                timefix -= Time.deltaTime;
                if (timefix >= 0.25)
                {

                    Timef1 = transfix1;
                    transfix1 = transform.position;
                }
                if (timefix <= 0)
                {
                    Timef2 = transfix2;
                    transfix2 = transform.position;
                    timefix = 0.4f;
                    if (Mathf.Approximately((transfix1.x - transfix2.x), 0))
                    {
                        direction = -direction;
                        transform.localScale = -vector;
                    }
                }
                transform.position += direction * SPD;
            }
        }

        if (PlayerPrefs.GetInt("level") == (int)iD_Level.levelNext)
        {
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 100);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            isSword = true;
            skAnimation.initialSkinName = PlayerPrefs.GetString("sword");
            ReloadSkeleton();
        }
        if (collision.gameObject.CompareTag("CoinItem"))
        {
            isWin = true;
            skAnimation.state.SetAnimation(0, "open ( k kiem)",true);
        }
        if (collision.gameObject.CompareTag("Trap") || collision.gameObject.CompareTag("Lava"))
        {
            isLose = true;
            skAnimation.state.SetAnimation(0, "quy goi", false);
        }
        if (collision.gameObject.CompareTag("Enemy") && isSword == false)
        {
            isLose = true;
            skAnimation.state.SetAnimation(0, "quy goi", false);
        }
    }
}
