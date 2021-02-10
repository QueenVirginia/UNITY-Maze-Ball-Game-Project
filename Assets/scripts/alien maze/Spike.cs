using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
     public AudioSource spikeSound;
    void OnTriggerEnter(Collider col)
    {
        spikeSound.Play();
        if(Collect.score >= 15)
        {
            Collect.score -= 15;
        }
        else if(Collect.score <15 && Collect.score >0)
        {
            Collect.score = 0;
        }
        
    }
}
