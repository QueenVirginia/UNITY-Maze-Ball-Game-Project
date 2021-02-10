using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpike : MonoBehaviour
{
    public AudioSource spikeSound;

    void OnTriggerEnter(Collider other)
    {
        spikeSound.Play();
        if (Scoring.theScore >= 15)
        {
            Scoring.theScore -= 15;
        }
        else if(Scoring.theScore <15 && Scoring.theScore >0)
        {
            Scoring.theScore = 0;
        }
    }
}
