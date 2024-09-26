using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Pin : MonoBehaviour
{
    public GameObject[] offTutorial;
    public bool runPLayer = false;
    private Vector3 pos_1;
    private BoxCollider2D box;
    public float speed = 1000f;
    private Rigidbody2D rb2d;
    private Vector3 vector = new Vector3(0, 0, 0);
    public GameObject d1;
    public GameObject d2;
    public bool isForce;
    private void Start()
    {
        isForce = true;
        pos_1 = transform.position;
        box = GetComponent<BoxCollider2D>();
        box.isTrigger = false;
        rb2d = GetComponent<Rigidbody2D>();
        vector = (d2.transform.position - d1.transform.position).normalized;
    }
    private void Update()
    {
        if (isForce == false)
        {
            rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (isForce == true)
        {
            rb2d.constraints = RigidbodyConstraints2D.None;
        }
    }
    private void OnMouseDown()
    {
        if (offTutorial.Length > 0)
        {
            for (int i = 0; i < offTutorial.Length; i++)
            {
                offTutorial[i].SetActive(false);
            }
        }
        runPLayer = true;
        isForce = true;
        box.isTrigger = true;
        rb2d.AddForce(vector * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("sensor"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("barries"))
        {
            isForce = false;
            transform.position = pos_1;
        }
    }
}