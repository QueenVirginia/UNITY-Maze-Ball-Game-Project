using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintu : MonoBehaviour
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

    private void OnTriggerExit(Collider col)
    {
        anim.SetBool("isOpening", false);
    }
}
