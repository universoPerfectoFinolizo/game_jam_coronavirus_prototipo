using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_cabina : MonoBehaviour
{

    public float tiempo_barrera;
    public GameObject barrera_obj;

    public GameObject panel;

    public GameObject auto;

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
            barrera_obj.SetActive(false);
            StartCoroutine(barrera());
        }
        else if (des == false)
        {
            auto.SetActive(false);
        }
        panel.SetActive(false);
    }

}
