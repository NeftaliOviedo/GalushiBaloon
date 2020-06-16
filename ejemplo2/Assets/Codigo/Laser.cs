using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour

 
{
    public float velocidad = 30;
  [SerializeField] GameObject gameObjects;

    void Update()
    {
          transform.position += transform.up* velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    
    {
        if (collision.gameObject.tag == "lefthWall")
        {
            Destroy(this.gameObject);
        }else if (collision.gameObject.tag=="Laser"){
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

   
    
}

