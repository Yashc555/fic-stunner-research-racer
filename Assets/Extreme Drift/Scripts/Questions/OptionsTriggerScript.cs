using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTriggerScript : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Collider")        
        { 
            Debug.Log("Now showing options");
            OptionShowScript.ShowOption1 = true;
        }
    }

    
        
}


