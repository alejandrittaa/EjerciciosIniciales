using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float PI = 3.14f;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(AreaCirculo(5));
        Debug.Log(AreaTriangulo(5, 10));
        Debug.Log(AreaCuadrado(10, 10));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float AreaCirculo(int radio)
    {
        float resultado = (radio * radio)*3.14f;
        return resultado;
    }

    int AreaTriangulo(int basetri, int altura)
    {
        int resultado = (basetri * altura)/2;
        return resultado;
    }

    int AreaCuadrado(int lado1, int lado2)
    {
        int resultado = lado1 * lado2;
        return resultado;
    }
}
