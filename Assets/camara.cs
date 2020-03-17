using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{

    public float velocidad = 0.1f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float cord_x = Input.GetAxis("Mouse X");
            float cord_y = Input.GetAxis("Mouse Y");
            transform.Translate(-cord_x * velocidad, -cord_y * velocidad, 0);
        }
    }
}
