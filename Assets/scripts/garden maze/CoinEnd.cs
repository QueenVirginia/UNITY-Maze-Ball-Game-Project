using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEnd : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider col)
    {
        collectSound.Play();
        updateScore.crystalCollected += 1;
        updateScore.score += 50;
        Destroy(gameObject);
    }
}
