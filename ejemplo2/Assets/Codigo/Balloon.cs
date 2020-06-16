using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
     [SerializeField] Vector3 force;
     GameObject[] gameObjects;
     [SerializeField] Sprite[] balloonSprites;

     private Rigidbody2D rb;
     private SpriteRenderer spriteRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = balloonSprites[Random.Range(0, 3)];

        transform.position = new Vector3(Random.Range(20f,29f),transform.position.y,transform.position.z);  
         
        force = new Vector3(Random.Range(-100,100),Random.Range(150,250),0);

        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    
    {
        if (collision.gameObject.tag == "topWall")
        {
            Destroy(this.gameObject);
        } else if (collision.gameObject.tag=="Laser"){
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
      
    }

}
