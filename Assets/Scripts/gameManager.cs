using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    [SerializeField] private string [] savedWords;
    [SerializeField] private string [] questions;
    [SerializeField] private string historia;

    [SerializeField] TextMeshProUGUI textQ;
    [SerializeField] TextMeshProUGUI textH;
    [SerializeField] GameObject buttonE;
    [SerializeField] GameObject buttonR;

    [SerializeField] TMP_InputField inputA;

    private int i=0;
    void Start()
    {
        textQ.text = questions[i];

        savedWords = new string[questions.Length];

        buttonR.SetActive(false);
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
        textH.text = string.Format(historia, savedWords);
        buttonR.SetActive(true);

        textQ.gameObject.SetActive(false);
        buttonE.SetActive(false);
        inputA.gameObject.SetActive(false);
    }

    public void reiniciarJuego()
    {
        /*i = 0;
        savedWords = new string[questions.Length];
        textQ.text = questions[i];

        textQ.gameObject.SetActive(true);
        buttonE.SetActive(true);
        inputA.gameObject.SetActive(true);

        textH.gameObject.SetActive(false);
        buttonR.SetActive(false);*/

        int indexEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexEscena);
    }
}
