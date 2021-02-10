using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabSpike : MonoBehaviour
{
    public AudioSource stabSound;

    void OnTriggerEnter(Collider col)
    {
        stabSound.Play();
        if(updateScore.score >= 15)
        {
            updateScore.score -= 15;
        }
        else if(updateScore.score <15 && updateScore.score >0)
        {
            updateScore.score = 0;
        }
        
    }
}
