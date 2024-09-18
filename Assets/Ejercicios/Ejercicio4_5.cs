using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    float conversion;
    float cantidadDeMonedas;
    float PI = 3.14f;

    void Start()
    {
        cantidadDeMonedas = (AreaCirculo(5));
        
        Convertir(cantidadDeMonedas, "Euros");
        Debug.Log("La conversion es " + conversion);
    }

    float Convertir(float cantidad, string moneda)
    {
        if (moneda == "Euros")
        {
            conversion = cantidad * 1.11f;
        }
        else if (moneda == "Dolares")
        {
            conversion = cantidad / 1.11f;
        }

        return conversion;
    }

    float AreaCirculo(int radio)
    {
        float resultado = (radio * radio) * 3.14f;
        return resultado;
    }

    int AreaTriangulo(int basetri, int altura)
    {
        int resultado = (basetri * altura) / 2;
        return resultado;
    }

    int AreaCuadrado(int lado1, int lado2)
    {
        int resultado = lado1 * lado2;
        return resultado;
    }
}
