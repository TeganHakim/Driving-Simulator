using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound : MonoBehaviour
{
    public AudioSource Impact;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Car")) 
        {
            Impact.Play();
        }
        
        
    }
  
}
