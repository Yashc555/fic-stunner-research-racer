using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSelect : MonoBehaviour
{
    public static bool startSelectingOption1 = false;
    public static bool startSelectingOption2 = false;
    public static bool startSelectingOption3 = false;
    public static bool startSelectingOption4 = false;
    public static bool startSelectingOption5 = false;

    public GameObject correctText;
    public GameObject wrongText;

    public static bool hideText = true;
    // Start is called before the first frame update
    void Start()
    {
        correctText.SetActive(false);
        wrongText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (startSelectingOption1)
        {
            hideText = false;
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                Debug.Log("CORRECT!!!  :) ");
                correctText.SetActive(true);
                wrongText.SetActive(false);
                startSelectingOption1 = false;
            }
            else if(Input.GetKeyUp(KeyCode.Alpha2) || Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4))
            {
                Debug.Log("Wrong :(");
                correctText.SetActive(false);
                wrongText.SetActive(true);
                startSelectingOption1 = false;
            }
        }
        if (startSelectingOption2)
        {
            hideText = false;
            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                Debug.Log("CORRECT!!!  :) ");
                correctText.SetActive(true);
                wrongText.SetActive(false);
                startSelectingOption2 = false;
            }
            else if (Input.GetKeyUp(KeyCode.Alpha2) || Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha4))
            {
                Debug.Log("Wrong :(");
                correctText.SetActive(false);
                wrongText.SetActive(true);
                startSelectingOption2 = false;
            }
        }
        if (startSelectingOption3)
        {
            hideText = false;
            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                Debug.Log("CORRECT!!!  :) ");
                correctText.SetActive(true);
                wrongText.SetActive(false);
                startSelectingOption3 = false;
            }
            else if (Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha4))
            {
                Debug.Log("Wrong :(");
                correctText.SetActive(false);
                wrongText.SetActive(true);
                startSelectingOption3 = false;
            }
        }
        if (startSelectingOption4)
        {
            hideText = false;
            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                Debug.Log("CORRECT!!!  :) ");
                correctText.SetActive(true);
                wrongText.SetActive(false);
                startSelectingOption4 = false;
            }
            else if (Input.GetKeyUp(KeyCode.Alpha2) || Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha4))
            {
                Debug.Log("Wrong :(");
                correctText.SetActive(false);
                wrongText.SetActive(true);
                startSelectingOption4 = false;
            }
        }

        if (startSelectingOption5)
        {
            hideText = false;
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                Debug.Log("CORRECT!!!  :) ");
                correctText.SetActive(true);
                wrongText.SetActive(false);
                startSelectingOption5 = false;
            }
            else if (Input.GetKeyUp(KeyCode.Alpha2) || Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4))
            {
                Debug.Log("Wrong :(");
                correctText.SetActive(false);
                wrongText.SetActive(true);
                startSelectingOption5 = false;
            }
        }


        if(hideText)
        {
            correctText.SetActive(false);
            wrongText.SetActive(false);
        }
    }
}
