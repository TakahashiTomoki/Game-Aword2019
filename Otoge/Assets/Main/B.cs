using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public A A;

    public static int OsitaB = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OsitaB = A.Osita;

        if (OsitaB == 1)
        {
            Debug.Log("うんち");
        }
    }
}
