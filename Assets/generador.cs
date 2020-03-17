using System.Collections;
using System.Collections.Generic;
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
    public int tiempo_oleada1;
    public int tiempo_oleada2;

    //tiempo en que dura el descanso:
    public float tiempo_descanso = 10f;

    //datos variados:
    int tiempo_oleada_n;
    int nivel_orda_ant = 0;

    private void Start()
    {
        StartCoroutine(generar(true));
    }

    IEnumerator generar(bool p1)
    {
        while (p1 == true)
        {
            //detectar nivel orda:
            if (nivel_orda == 1)
            {
                //tiempo oleada:
                if (tiempo_oleada_n < tiempo_oleada1)
                {
                    yield return new WaitForSeconds(tiempo_generar);
                    int r1 = Random.Range(0, 10);
                    print(r1);

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
                else
                {
                    nivel_orda_ant = nivel_orda;
                    nivel_orda = 100;
                    tiempo_oleada_n = 0;
                }
                
            }
            else if (nivel_orda==2)
            {
                if (tiempo_oleada_n < tiempo_oleada2)
                {
                    yield return new WaitForSeconds(tiempo_generar);
                    int r1 = Random.Range(0, 10);
                    print(r1);

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
                else
                {
                    nivel_orda_ant = nivel_orda;
                    nivel_orda = 100;
                    tiempo_oleada_n = 0;
                }
                
            }
            else if (nivel_orda == 100)
            {
                //modo descanso:
                yield return new WaitForSeconds(tiempo_descanso);
                nivel_orda = nivel_orda_ant;
                nivel_orda++;
            }
            else
            {
                p1 = false;
            }
            
        }
    }

}
