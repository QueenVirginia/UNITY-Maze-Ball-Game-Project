﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerbang : MonoBehaviour
{
    Animator anim;

    void Awake() 
    {
        anim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider col)
    {
        anim.SetBool("isOpening", true);
    }
}