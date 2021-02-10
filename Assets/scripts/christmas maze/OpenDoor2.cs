using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor2 : MonoBehaviour
{
    Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
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
