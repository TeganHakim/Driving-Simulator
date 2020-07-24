using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NitroBar : MonoBehaviour
{

    public Slider slider;
    public float currentNitro;
    public float maxNitro;
    public bool IsNitroActive;

    public ParticleSystem flames;
    public ParticleSystem flames2;
    
    public void Start()
    {
        currentNitro = 1;
        IsNitroActive = true;
    }

    public void Update()
    {
        SetNitro(currentNitro);

        if (currentNitro <= 0)
        {
            IsNitroActive = false;
        }
    }
   
    public void SetNitro(float nitro)
    {
        slider.value = nitro;
    }

    public void UseNitro(float nitro)
    {
        currentNitro -= nitro;
        Flames();
    }

    public void Flames()
    {        
        flames.Play();
        flames2.Play();
    }

}
