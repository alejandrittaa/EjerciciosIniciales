    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombrecompleto;
    void Start()
    {
        ConstruirNombre("Alejandra", " Cortés", " Reyero");
        Debug.Log(nombrecompleto);
    }

    string ConstruirNombre(string nombre, string ap1, string ap2)
    {
        nombrecompleto = nombre + ap1 + ap2;
        return nombrecompleto;
    }
}
