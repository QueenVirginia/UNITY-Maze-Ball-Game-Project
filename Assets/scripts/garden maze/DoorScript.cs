using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator anim;
    public AudioSource slidingSound;

    void Awake() 
    {
        anim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider col)
    {
        anim.SetBool("isOpening", true);
        slidingSound.Play();
    }

    private void OnTriggerExit(Collider col)
    {
        anim.SetBool("isOpening", false);
        slidingSound.Play();
    }
}
