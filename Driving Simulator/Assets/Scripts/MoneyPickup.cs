using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPickup : MonoBehaviour
{
    public MoneyManager money;
    public AudioSource chaChing;

    //If car collects money
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            chaChing.Play();
            money.money += 1;
            Destroy(gameObject);
            
        }
    }

}
