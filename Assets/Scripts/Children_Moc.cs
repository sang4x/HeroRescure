using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Children_Moc : MonoBehaviour
{
    private BoxCollider2D coll2D;
    public GameObject moc;
    private BoxCollider2D mocbox;
    private void Start()
    {
        coll2D = GetComponent<BoxCollider2D>();
        mocbox = moc.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (mocbox.isTrigger == true)
        {
            coll2D.isTrigger = true;
        }
        if (mocbox.isTrigger == false)
        {
            coll2D.isTrigger = false;
        }
    }
}
