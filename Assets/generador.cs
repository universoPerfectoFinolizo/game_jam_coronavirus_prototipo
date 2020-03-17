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

    private void Start()
    {
        generar();
    }

    private void generar()
    {
        while (nivel_orda <= 100)
        {
                //tiempo oleada:
                if (tiempo_oleada_n < tiempos_oleadas[nivel_orda-1])
                {
                    StartCoroutine(esperarTiempo(tiempo_generar));
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
                    StartCoroutine(esperarTiempo(tiempo_descanso));
                }
        }
    }
        
    

    private IEnumerator esperarTiempo (float tiempo){
        yield return new WaitForSeconds(tiempo);
        nivel_orda++;
        tiempo_oleada_n = 0;
    }

}
