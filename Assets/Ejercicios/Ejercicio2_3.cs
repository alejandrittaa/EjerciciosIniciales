using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 5.5f;
    float op1;
    float op2;
    float op3;
    float op4;
    float op5;

    // Start is called before the first frame update
    void Start()
    {

        op1 = vidas * exp;
        Debug.Log("Las vidas * exp es igual a " + op1);
        op2 = vidas / exp;
        Debug.Log("Las vidas / exp es igual a " + op2);
        op3 = vidas % exp;
        Debug.Log("Las vidas % exp es igual a " + op3);
        op4 = vidas * 2;
        Debug.Log("El doble de vidas es " + op4);
        op5 = exp * 3;
        Debug.Log("El triple de exp es " + op5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
