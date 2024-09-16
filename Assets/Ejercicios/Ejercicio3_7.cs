using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{

    [SerializeField] int basetri;
    [SerializeField] int alturatri;
    int area;


    // Start is called before the first frame update
    void Start()
    {
        area = (basetri * alturatri)/2;
        Debug.Log("El área de tu triángulo es de " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
