using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
  
   void OnTriggerExit(Collider other)
   
   {

    Destroy(other.gameObject);
    Debug.Log("SE MATO");

   }

}
