using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoint : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider col)
    {
        collectSound.Play();
        PointTerbaru.crystalCollected += 1;
        PointTerbaru.score += 10;
        Destroy(gameObject);
    }
}
