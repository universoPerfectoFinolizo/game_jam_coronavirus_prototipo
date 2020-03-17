using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_cabina : MonoBehaviour
{

    public float tiempo_barrera;
    public GameObject barrera_obj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "auto_infectado")
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.tag == "auto_normal")
        {
            barrera_obj.SetActive(false);
            StartCoroutine(barrera());
        }
    }

    IEnumerator barrera()
    {
        yield return new WaitForSeconds(tiempo_barrera);
        barrera_obj.SetActive(true);
    }

}
