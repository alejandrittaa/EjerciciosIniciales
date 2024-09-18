using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{

    float velocidadm;

    void Start()
    {
        Conversion(5);
        Debug.Log("El dato introducido convertido a metros es " + velocidadm);
    }

    float Conversion (float velocidadkm)
    {
        velocidadm = velocidadkm * 1000;
        return velocidadm;
    }
}
