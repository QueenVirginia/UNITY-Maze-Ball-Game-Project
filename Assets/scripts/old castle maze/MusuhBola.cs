using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusuhBola : MonoBehaviour
{
    public AudioSource spikeSound;

    void OnTriggerEnter(Collider col)
    {
        spikeSound.Play();
        if(PointTerbaru.score >= 15)
        {
            PointTerbaru.score -= 15;
        }
        else if(PointTerbaru.score <15 && PointTerbaru.score >0)
        {
            PointTerbaru.score = 0;
        }
        
    }
}
