using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouFell : MonoBehaviour
{
    public GameObject Youfell;
    public AudioSource carSplash;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            carSplash.Play();

            Youfell.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
