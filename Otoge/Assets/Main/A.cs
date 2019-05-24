using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{

    public static int Osita = 0;//スペースが押されたかどうかを調べる。

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Osita = 1;
        }
    }
}
