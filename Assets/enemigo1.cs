using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo1 : MonoBehaviour
{

    public GameObject adelante;
    public float velocidad;
    detector_adelante detect_adelante;


    private void Start()
    {
        detect_adelante = adelante.GetComponent<detector_adelante>();
    }


    private void Update()
    {
        if (detect_adelante.objeto == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, adelante.transform.position, velocidad * Time.deltaTime);
        }
    }

}
