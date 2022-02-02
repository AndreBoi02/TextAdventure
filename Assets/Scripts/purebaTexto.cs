using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class purebaTexto : MonoBehaviour
{
    public TextMeshProUGUI textoEditable;
    public float x;
    public float y;
    public float z;
    public Color changeColor = Color.white;
    void Start()
    {
        textoEditable.text = "Pathetic.";
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            textoEditable.color = new Color(x, y, z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            textoEditable.color = changeColor;
        }
    }
}
