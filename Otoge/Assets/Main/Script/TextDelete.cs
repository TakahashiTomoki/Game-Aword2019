﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Destroy(gameObject);
        }
    }
}
