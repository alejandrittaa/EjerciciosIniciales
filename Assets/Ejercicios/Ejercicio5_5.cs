using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel;

    void Start()
    {
        if (nivel % 2 == 0)
        {
            Debug.Log("El número de nivel es par");
        }else
        {
            Debug.Log("El número de nivel es impar");
        }
    }
}
