using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionShowScript : MonoBehaviour
{
    public static bool ShowOption1 = false;
    public static bool ShowOption2 = false;
    public static bool ShowOption3 = false;
    public static bool ShowOption4 = false;
    public static bool ShowOption5 = false;


    public TextMeshProUGUI Question1_Option1;
    public TextMeshProUGUI Question1_Option2;
    public TextMeshProUGUI Question1_Option3;
    public TextMeshProUGUI Question1_Option4;

    public TextMeshProUGUI Question2_Option1;
    public TextMeshProUGUI Question2_Option2;
    public TextMeshProUGUI Question2_Option3;
    public TextMeshProUGUI Question2_Option4;

    public TextMeshProUGUI Question3_Option1;
    public TextMeshProUGUI Question3_Option2;
    public TextMeshProUGUI Question3_Option3;
    public TextMeshProUGUI Question3_Option4;

    public TextMeshProUGUI Question4_Option1;
    public TextMeshProUGUI Question4_Option2;
    public TextMeshProUGUI Question4_Option3;
    public TextMeshProUGUI Question4_Option4;

    public TextMeshProUGUI Question5_Option1;
    public TextMeshProUGUI Question5_Option2;
    public TextMeshProUGUI Question5_Option3;
    public TextMeshProUGUI Question5_Option4;

    private void Start()
    {
        Question1_Option1.gameObject.SetActive(false);
        Question1_Option2.gameObject.SetActive(false);
        Question1_Option3.gameObject.SetActive(false);
        Question1_Option4.gameObject.SetActive(false);

        Question2_Option1.gameObject.SetActive(false);
        Question2_Option2.gameObject.SetActive(false);
        Question2_Option3.gameObject.SetActive(false);
        Question2_Option4.gameObject.SetActive(false);

        Question3_Option2.gameObject.SetActive(false);
        Question3_Option3.gameObject.SetActive(false);
        Question3_Option4.gameObject.SetActive(false);
        Question3_Option1.gameObject.SetActive(false);

        Question4_Option1.gameObject.SetActive(false);
        Question4_Option2.gameObject.SetActive(false);
        Question4_Option3.gameObject.SetActive(false);
        Question4_Option4.gameObject.SetActive(false);

        Question5_Option1.gameObject.SetActive(false);
        Question5_Option2.gameObject.SetActive(false);
        Question5_Option3.gameObject.SetActive(false);
        Question5_Option4.gameObject.SetActive(false);

    }
    void Update()
    {

        if (ShowOption1 == true)
        {
            Question1_Option1.gameObject.SetActive(true);
            Question1_Option2.gameObject.SetActive(true);
            Question1_Option3.gameObject.SetActive(true);
            Question1_Option4.gameObject.SetActive(true);

            ShowOption1 = false;

            StartCoroutine("RemoveOptions1");

        }

        if (ShowOption2 == true)
        {
            Question2_Option1.gameObject.SetActive(true);
            Question2_Option2.gameObject.SetActive(true);
            Question2_Option3.gameObject.SetActive(true);
            Question2_Option4.gameObject.SetActive(true);

            ShowOption2 = false;

            StartCoroutine("RemoveOptions2");

        }

        if (ShowOption3 == true)
        {
            Question3_Option1.gameObject.SetActive(true);
            Question3_Option2.gameObject.SetActive(true);
            Question3_Option3.gameObject.SetActive(true);
            Question3_Option4.gameObject.SetActive(true);

            ShowOption3 = false;

            StartCoroutine("RemoveOptions3");

        }

        if (ShowOption4 == true)
        {
            Question4_Option1.gameObject.SetActive(true);
            Question4_Option2.gameObject.SetActive(true);
            Question4_Option3.gameObject.SetActive(true);
            Question4_Option4.gameObject.SetActive(true);

            ShowOption4 = false;

            StartCoroutine("RemoveOptions4");

        }

        if (ShowOption5 == true)
        {
            Question5_Option1.gameObject.SetActive(true);
            Question5_Option2.gameObject.SetActive(true);
            Question5_Option3.gameObject.SetActive(true);
            Question5_Option4.gameObject.SetActive(true);

            ShowOption5 = false;

            StartCoroutine("RemoveOptions5");

        }

    }
    IEnumerator RemoveOptions1()
    {
        OptionsSelect.startSelectingOption1 = true;
        Debug.Log(OptionsSelect.startSelectingOption1);
        yield return new WaitForSeconds(10);

        Question1_Option1.gameObject.SetActive(false);
        Question1_Option2.gameObject.SetActive(false);
        Question1_Option3.gameObject.SetActive(false);
        Question1_Option4.gameObject.SetActive(false);

        OptionsSelect.startSelectingOption1 = false;

        OptionsSelect.hideText = true;
    }
    IEnumerator RemoveOptions2()
    {
        OptionsSelect.startSelectingOption2 = true;
        yield return new WaitForSeconds(10);

        Question2_Option1.gameObject.SetActive(false);
        Question2_Option2.gameObject.SetActive(false);
        Question2_Option3.gameObject.SetActive(false);
        Question2_Option4.gameObject.SetActive(false);

        Debug.Log("Options for Q2 removed");

        OptionsSelect.startSelectingOption2 = false;

        OptionsSelect.hideText = true;
    }

    IEnumerator RemoveOptions3()
    {
        OptionsSelect.startSelectingOption3 = true;
        yield return new WaitForSeconds(10);

        Question3_Option1.gameObject.SetActive(false);
        Question3_Option2.gameObject.SetActive(false);
        Question3_Option3.gameObject.SetActive(false);
        Question3_Option4.gameObject.SetActive(false);

        Debug.Log("Options for Q3 removed");

        OptionsSelect.startSelectingOption3 = false;

        OptionsSelect.hideText = true;
    }
    IEnumerator RemoveOptions4()
    {
        OptionsSelect.startSelectingOption4 = true;
        yield return new WaitForSeconds(10);

        Question4_Option1.gameObject.SetActive(false);
        Question4_Option2.gameObject.SetActive(false);
        Question4_Option3.gameObject.SetActive(false);
        Question4_Option4.gameObject.SetActive(false);

        Debug.Log("Options for Q4 removed");

        OptionsSelect.startSelectingOption4 = false;

        OptionsSelect.hideText = true;

    }

    IEnumerator RemoveOptions5()
    {
        OptionsSelect.startSelectingOption5 = true;
        yield return new WaitForSeconds(10);

        Question5_Option1.gameObject.SetActive(false);
        Question5_Option2.gameObject.SetActive(false);
        Question5_Option3.gameObject.SetActive(false);
        Question5_Option4.gameObject.SetActive(false);

        Debug.Log("Options for Q5 removed");

        OptionsSelect.startSelectingOption5 = false;

        OptionsSelect.hideText = true;
    }

}
