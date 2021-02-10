using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCrystal : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Collect.crystalCollected += 1;
        Collect.score += 10;
        Destroy(gameObject);
    }
}
