using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimation : MonoBehaviour
{
    Animator spikeAnimator;
    public AudioSource spikemoveSound;

    private void OnTriggerEnter(Collider other)
    {
        spikemoveSound.Play();
        spikeAnimator.SetBool("isFront", true);
    }

    private void OnTriggerExit(Collider other)
    {
        spikeAnimator.SetBool("isFront", false);
    }

    void Awake()
    {
        spikeAnimator = this.transform.parent.GetComponent<Animator>();
    }
}
