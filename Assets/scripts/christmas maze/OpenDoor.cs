using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator doorAnimator;
    public AudioSource doorSound;
   
    private void OnTriggerEnter(Collider other)
    {
        doorSound.Play();
        doorAnimator.SetBool("isOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("isOpening", false);
    }

    void Awake()
    {
        doorAnimator = this.transform.parent.GetComponent<Animator>();
    }
}
