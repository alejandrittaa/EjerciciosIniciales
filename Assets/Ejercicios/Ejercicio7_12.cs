using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{

    //NO ENTIENDO PORQUE NO FUNCIONA, Y PORQUE NO SALEN LAS VARIABLES SERIALIZADAS EN UNITY :(, solo salen si comento el código osea que supongo que hay algo mal, pero no logro ver que es

    [SerializeField] int num1;
    [SerializeField] int num2;

    // Start is called before the first frame update
    /*void Start()
    {
        int resultado = SumarTodosLosNumeros(num1, num2);
        Debug.Log(resultado);
    }

    int SumarTodosLosNumeros(int numero1,int numero2)
    {
        int suma = 0;
        if (numero1 > numero2)
        {
            for (int i = numero2; i < numero1; i++)
            {
                Debug.Log(i);
                suma += i;
            }
            Debug.Log("La suma de todos los número entre " + numero1 + " y " + numero2 + " es: " + suma);
            return suma;
        }
        else if (numero2 < numero1)
        {
            for (int i = numero1; i < numero2; i++)
            {
                Debug.Log(i);
                suma += i;
            }
            Debug.Log("La suma de todos los número entre " + numero2 + " y " + numero1 + " es: " + suma);
            return suma;
        }else
        {
            Debug.Log("Introduce dos numero distintos");
        }

    }*/
}
