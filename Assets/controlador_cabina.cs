using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_cabina : MonoBehaviour
{

    public float tiempo_barrera;
    public GameObject barrera_obj;

    public GameObject panel;

    public GameObject auto;

    public GameObject contr_moneda;
    controlador_monedas contr_monedas_script;

    private void Start()
    {
        contr_moneda = GameObject.FindGameObjectWithTag("controlador_moneda");
        contr_monedas_script = contr_moneda.GetComponent<controlador_monedas>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "auto_infectado" || collision.tag=="auto_normal")
        {
            auto = collision.gameObject;
            panel.SetActive(true);
        }
    }

    IEnumerator barrera()
    {
        yield return new WaitForSeconds(tiempo_barrera);
        barrera_obj.SetActive(true);
    }

    public void desicion(bool des)
    {
        if (des == true)
        {
            if(auto.tag== "auto_normal")
            {
                contr_monedas_script.sumar_punto(2);
            }
            barrera_obj.SetActive(false);
            StartCoroutine(barrera());
        }
        else if (des == false)
        {
            if (auto.tag == "auto_normal")
            {
                contr_monedas_script.restar_punto(1);
            }
            auto.SetActive(false);
        }
        panel.SetActive(false);
    }

}
