using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFinish : MonoBehaviour
{
    public AudioSource collectSound;
     
    void OnTriggerEnter(Collider other)
  {
      collectSound.Play();
      Collect.crystalCollected += 1;
      Collect.score += 50;
      Destroy(gameObject);
  }
}
