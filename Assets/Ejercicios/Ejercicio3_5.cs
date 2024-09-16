using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{

    [SerializeField] float radiocir;
    float longitud;
    float area;

    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * 3.14f * radiocir;
        area = 3.14f * (radiocir * radiocir);
        Debug.Log("El área de tu circunferencia es de " + area + " y su longitud es de " + longitud);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
