using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    [SerializeField] private string [] savedWords;
    [SerializeField] private string [] questions;
    [SerializeField] private string historia;

    [SerializeField] TextMeshProUGUI textQ;
    [SerializeField] TextMeshProUGUI textH;
    [SerializeField] GameObject button;

    [SerializeField] TMP_InputField inputA;

    private int i=0;
    void Start()
    {
        textQ.text = questions[i];

        savedWords = new string[questions.Length];
    }

    public void saveAnswers ()
    {
        savedWords[i] = inputA.text;

        inputA.text = "";

        /*if (savedWords[i] != null)
        {
            i += 1;
        }*/
        i++;

        if (i >= questions.Length)
        {
            ShowHistoria();
            return;
        }
        textQ.text = questions[i];
    }

    void ShowHistoria()
    {
        textH.gameObject.SetActive(true);

        textQ.gameObject.SetActive(false);
        button.SetActive(false);
        inputA.gameObject.SetActive(false);
    }
}
