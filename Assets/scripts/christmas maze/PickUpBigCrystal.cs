using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBigCrystal : MonoBehaviour
{
    public AudioSource crystalSound;

    void OnTriggerEnter(Collider other)
    {
        crystalSound.Play();
        Scoring.crystalCollected += 1;
        Scoring.theScore += 50;
        Destroy(gameObject);
    }
}
