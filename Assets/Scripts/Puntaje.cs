using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Puntaje : MonoBehaviour
{

    private float Scores;
    private TextMeshProUGUI textMesh;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        textMesh.text = Scores.ToString("0");
    }
    public void SumaPuntos(float puntosEntrada)
    {
        Scores = Scores + puntosEntrada;
    }
}
