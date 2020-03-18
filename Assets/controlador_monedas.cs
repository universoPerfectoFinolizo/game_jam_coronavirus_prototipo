using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlador_monedas : MonoBehaviour
{

    int puntos = 0;
    public Text texto;

    public void sumar_punto(int valor)
    {
        puntos += valor;
        texto.text = "X" + puntos;
    }

    public void restar_punto(int valor)
    {
        puntos -= valor;
        texto.text = "X" + puntos;
    }

}
