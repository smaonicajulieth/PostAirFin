﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAtras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {

            if (Input.GetKeyUp(KeyCode.Escape))
            {

                //quit application on return button

                Application.Quit();

                return;

            }

        }
    }
}
