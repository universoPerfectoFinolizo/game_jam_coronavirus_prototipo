using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector_adelante : MonoBehaviour
{

    public bool objeto = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "auto_normal" || collision.tag == "auto_infectado" || collision.tag=="barrera")
        {
            objeto = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "auto_normal" || collision.tag == "auto_infectado" || collision.tag=="barrera")
        {
            objeto = false;
        }
    }

}
