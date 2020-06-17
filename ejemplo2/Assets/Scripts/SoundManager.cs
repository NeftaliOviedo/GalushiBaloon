using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este es el script del sonido del laser♥
public class SoundManager : MonoBehaviour


{
//Instanciamos el componente
    [SerializeField] AudioClip shootSound;
    private  AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

 
    public void PlaySound(){

        src.PlayOneShot(shootSound);



    }
}
