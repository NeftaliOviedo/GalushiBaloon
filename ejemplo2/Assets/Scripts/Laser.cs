using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
//Aca Hace el efecto del lacer
 
{
    
    public float velocidad = 10;

     [SerializeField] SoundManager soundManager;
    void Update()
    {
         
          transform.position += transform.up* velocidad * Time.deltaTime;
          
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    
    
    { 
        
       
        if (collision.gameObject.tag == "lefthWall")
        {
            Destroy(this.gameObject);
        }
        //Metodo del laser
          soundManager.PlaySound();
    }

   
    
}

