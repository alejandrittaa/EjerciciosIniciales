using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    bool resultado;
    int numero = 25;
    void Start()
    {
        numeroPrimo(numero);
        Debug.Log("¿Es un número primo? " + resultado);
    }

    //No se como hacer para decirle al programa "solo es primo si ocurre esto y nada más, como con el 25, que es divisible entre si mismo y el 1, pero al ser divisible tambien entre 5, ya no es primo, pero no se como hacerlo"
    bool numeroPrimo(int cantidad)
    {
        if (cantidad % cantidad == 0 && cantidad % 1 == 0)
        {
            resultado = true;
        }
        else if (cantidad % cantidad == 0 || cantidad % 1 == 0)
        {
            resultado = false;
        }

        return resultado;
    }
}
