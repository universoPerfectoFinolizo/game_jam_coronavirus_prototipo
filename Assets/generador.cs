using System.Collections;
using UnityEngine;

public class generador : MonoBehaviour
{

    //eneigos y personas
    public GameObject enemigo1;
    public GameObject persona;

    //nivel orda:
    public int nivel_orda=1;

    //tiempo en que tarda en generar eneigos:
    public float tiempo_generar;

    //tiempo que dura las oleadas:
    public int[] tiempos_oleadas = new int[]{10,20,30} ;

    //tiempo en que dura el descanso:
    public float tiempo_descanso = 10f;

    //datos variados:
    int tiempo_oleada_n;

    public bool ocupado_b = false;
    public bool ocupado = false;

    private void Start()
    {
        StartCoroutine(generar());
    }

    private void Update()
    {
        
    }

    IEnumerator generar()
    {
        while (nivel_orda <= 100)
        {
            if (ocupado == false)
            {
                if (tiempo_oleada_n < tiempos_oleadas[nivel_orda - 1])
                {
                    yield return new WaitForSeconds(tiempo_generar);
                    int r1 = Random.Range(0, 10);
                    print(r1);
                    if (ocupado == false)
                    {
                        switch (r1)
                        {
                            case 0:
                                GameObject persona1 = GameObject.Instantiate(persona, transform.position, transform.rotation) as GameObject;
                                break;
                            default:
                                GameObject enemigo1_1 = GameObject.Instantiate(enemigo1, transform.position, transform.rotation) as GameObject;
                                break;
                        }
                        tiempo_oleada_n++;
                    }
                }
                else
                {
                    yield return new WaitForSeconds(tiempo_descanso);
                    nivel_orda++;
                    tiempo_oleada_n = 0;
                }
            }
            else
            {
                yield return new WaitForSeconds(1f);
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="auto_infectado" || collision.tag == "auto_normal")
        {
            ocupado_b = true;
            StartCoroutine(ocupado_f());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "auto_infectado" || collision.tag == "auto_normal")
        {
            ocupado_b = false;
            ocupado = false;
        }
    }

    IEnumerator ocupado_f()
    {
        yield return new WaitForSeconds(2);
        if (ocupado_b == true)
        {
            ocupado = true;
        }
    }

    //261 30

}
