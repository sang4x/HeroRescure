using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Holder : MonoBehaviour
{
    public static Data_Holder instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
