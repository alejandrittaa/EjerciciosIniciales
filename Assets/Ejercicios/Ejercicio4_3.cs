using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    float conversion;
    void Start()
    {
        Convertir(2.50f, "Euros");
        Debug.Log("La conversion es " + conversion);
    }


    float Convertir (float cantidad, string moneda)
    {
        if(moneda == "Euros")
        {
            conversion = cantidad * 1.11f;
        }else if(moneda == "Dolares")
        {
            conversion = cantidad / 1.11f;
        }

        return conversion;
    }
}
