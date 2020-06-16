using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Limite : MonoBehaviour
{
  
   void OnTriggerExit(Collider other)
   
   {

        if (gameObject.tag == "inferior")
        {
            Debug.Log("SE MATO");
            SceneManager.LoadScene(2);
        }

    }


}
