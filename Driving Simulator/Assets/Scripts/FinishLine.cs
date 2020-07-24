using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject win;

    //If car goes through trigger, you win is active
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            win.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
