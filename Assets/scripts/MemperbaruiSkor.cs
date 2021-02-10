using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemperbaruiSkor : MonoBehaviour
{
    public AudioSource collectSound;
     
    void OnTriggerEnter(Collider other)
  {
      collectSound.Play();
      Collect.score += 10;
      Destroy(gameObject);
  }
}
