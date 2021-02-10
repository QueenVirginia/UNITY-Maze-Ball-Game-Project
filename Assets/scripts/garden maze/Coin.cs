using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider col)
    {
        collectSound.Play();
        updateScore.crystalCollected += 1;
        updateScore.score += 10;
        Destroy(gameObject);
    }
}
