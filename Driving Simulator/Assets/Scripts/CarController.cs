using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public float speed = 0f;
    public float maxSpeed = 20f;
    public float nitroSpeed = 50f;
    public float turnSpeed = 100f;
    public int W_S;
    public bool isMoving;

    public NitroBar nitro;
    public float nitroJuice;
    
    //This is not clean code in any way haha, but it gets the job done!
    void Update()
    {        
        float turnInput = Input.GetAxis("Horizontal"); 
        // Only turn if moving
        if (isMoving)
        {
            transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.W) && speed < maxSpeed)
        {
            speed += 0.5f;
            W_S = 1;            
        }
        else if (Input.GetKey(KeyCode.S) && speed < maxSpeed)
        {
            speed += 0.5f;
            W_S = 2;            
        }
        else 
        {
            speed -= 0.5f;            
        }

        if (Input.GetKey(KeyCode.LeftShift) && nitro.IsNitroActive == true)
        {
            W_S = 1;            
            if (speed < nitroSpeed)
            {
                speed += 4;
                nitroJuice = 0.00755f;
                nitro.UseNitro(nitroJuice);
            }
            else
            {
                speed = nitroSpeed;
            }
            
            
        }

        if (speed <= 0)
        {
            speed = 0;
            isMoving = false;
        }
        //Change turn speed depending on speed
        else if (speed > 20)
        {
            turnSpeed = 70;
        }
        else if (speed < 20)
        {
            turnSpeed = 100;
        }
        if (speed > 0f) 
        {
            isMoving = true;
        }
        


        if (W_S == 1)
        {            
            transform.Translate(Vector3.forward * 1 * speed * Time.deltaTime);
        }
        if (W_S == 2)
        {
            transform.Translate(Vector3.forward * -1 * speed * Time.deltaTime);
        }
        

    }      
}
