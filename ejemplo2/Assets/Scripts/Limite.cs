using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Limite : MonoBehaviour
{
  
   void OnTriggerExit(Collider other)
   
   {

<<<<<<< HEAD
<<<<<<< HEAD
        if (other.tag == "inferior")
=======
        if (other.gameObject.tag == "inferior")
>>>>>>> parent of 2a9b734... Tamo Terminando
=======
        if (other.gameObject.tag == "inferior")
>>>>>>> parent of 2a9b734... Tamo Terminando
        {
            Debug.Log("SE MATO");
            SceneManager.LoadScene(2);
        }

    }



}
