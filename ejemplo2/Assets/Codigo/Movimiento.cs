using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
   
    public GameObject disparo;
    public Transform lugardisparo;
    public float velocidad = 8f;

    public float veldisparo;

    private float nextdisparo; 


    void Start()
    {
       transform.position = new Vector3 (36,5,1); // aparicion nave
    }

    
    private void Update()


    {
        Movement();
      
      if (Input.GetButton("Fire1") && Time.time > nextdisparo)
       {

          nextdisparo = Time.time + veldisparo;
          Instantiate(disparo, lugardisparo.position, lugardisparo.rotation);         
       }
     
    }
         
          private void Movement()

    { 

        float horizontalInput = Input.GetAxis("Horizontal");

       transform.Translate(Vector3.right * velocidad * horizontalInput * Time.deltaTime);

    }

   

}
