using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{

    [SerializeField] int num1;
    [SerializeField] int num2;
    int resta;

    void Start()
    {
        //comprabamos que ninguno de los numeros sea modulo de 0
        if (num1 % 2 != 0 && num2 % 2 != 0)
        {
            resta = num1 - num2;
            Debug.Log("La resta de " + num1 + " menos " + num2 + " es " + resta );
        }
    }
}
