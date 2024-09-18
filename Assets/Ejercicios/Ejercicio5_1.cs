using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int puntos1;
    [SerializeField] int puntos2;

    void Start()
    {
        if(puntos1 == puntos2)
        {
            Debug.Log("La batalla está reñida, ambos jugadores tienen los mismos puntos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
