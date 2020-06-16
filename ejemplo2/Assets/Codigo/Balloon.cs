using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour //Prefaps Globos.
{
     [SerializeField] Vector3 force;
     [SerializeField] Sprite[] balloonSprites;

     private Rigidbody2D rb;
     private SpriteRenderer spriteRenderer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = balloonSprites[Random.Range(0, 3)];//Velocidad de Globos hacia arriba y aleatorios.

        //Posicion de Spawn de Globos de x a x.
        transform.position = new Vector3(Random.Range(20f,29f),transform.position.y,transform.position.z);
      
       force = new Vector3(Random.Range(-100,100),Random.Range(150,250),0);

        rb.AddForce(force);
    }

    void Update()
    {
        
    }

     //Cuando los glovos tocan el "TopWall" desaparecen y cuando tocan "LeftWall" colisionan.
    private void OnTriggerEnter2D(Collider2D collision) 
    
    {
        if (collision.gameObject.tag == "topWall")
        {
            Destroy(this.gameObject);
        }
    }

}
