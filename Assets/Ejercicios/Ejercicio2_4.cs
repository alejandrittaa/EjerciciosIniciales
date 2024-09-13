using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{

    int vidas = 100;
    int op1;
    int op2;
    int op3;

    // Start is called before the first frame update
    void Start()
    {
        //no entiendo, si quieres que haga las operaciones siempre sobre el valor inicial de la vida o si lo hago sobre el valor que obtiene la vida trás cada operación
        /*suponiendo que sea el primer caso:
        Debug.Log("Si incrementamos las vidas actuales en 77 obtendriamos " + (vidas + 77) + " vidas");
        Debug.Log("Si le restamos 3 obtendriamos " + (vidas + 3) + " vidas");
        Debug.Log("Si cuadriplicamos su valor obtendriamos " + (vidas * 4) + " vidas");
        */

        //suponiendo que sea el segundo caso
        op1 = vidas + 77;
        Debug.Log("El resultado de sumarle a vidas 77 es " + op1);
        op2 = op1 - 3;
        Debug.Log("El resultado de restarle 3 es " + op2);
        op3 = op2 * 4;
        Debug.Log("El resultado de cuadruplicarlo es " + op3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
