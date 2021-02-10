using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paku : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
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
