using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionTrigger5 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Collider")
        {
            Debug.Log("Now showing options 2");
            OptionShowScript.ShowOption5 = true;
        }
    }
}