using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                                                  //Health bar is called
        HealthBarHandler.SetHealthBarValue(1);
    }

    
    private void Update()


    {

        //the healthbar lose life test
        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue());
        if (HealthBarHandler.GetHealthBarValue()==0f)
        {
                       
                SceneManager.LoadScene(2);
            
        }
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

    private void OnTriggerEnter2D(Collider2D collision)

    {
       
       
    }




}
