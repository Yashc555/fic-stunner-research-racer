using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTriggerScript3 : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Collider")        
        { 
            Debug.Log("Now showing options");
            OptionShowScript.ShowOption3 = true;
        }
    }

    
        
}


