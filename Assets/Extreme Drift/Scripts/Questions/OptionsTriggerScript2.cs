using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTriggerScript2 : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Collider")        
        { 
            Debug.Log("Now showing options");
            OptionShowScript.ShowOption2 = true;
        }
    }

    
        
}


