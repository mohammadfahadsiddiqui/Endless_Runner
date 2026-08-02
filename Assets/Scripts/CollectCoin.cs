using System;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
  [SerializeField] AudioSource coinFX;
    void OnTriggerEnter2D(Collider2D other)
    {
       coinFX.Play();
       
    }
}
