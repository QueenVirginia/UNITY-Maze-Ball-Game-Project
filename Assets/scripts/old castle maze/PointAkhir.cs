using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAkhir : MonoBehaviour
{
    public AudioSource collectSound;
    
    void OnTriggerEnter(Collider col)
    {
        collectSound.Play();
        PointTerbaru.crystalCollected += 1;
        PointTerbaru.score += 50;
        Destroy(gameObject);
    }
}
