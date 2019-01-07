﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanControls : MonoBehaviour {

    static Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 1.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if(z != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
