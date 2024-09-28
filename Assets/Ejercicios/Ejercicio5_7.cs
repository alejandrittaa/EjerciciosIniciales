using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] float vel1;
    [SerializeField] float vel2;
    [SerializeField] float vel3;

    // Start is called before the first frame update
    void Start()
    {
        if(vel1 > vel2 && vel1 > vel3)
        {
            Debug.Log("Atacará primero jugador1");
        }else if (vel2 > vel1 && vel2 > vel3)
        {
            Debug.Log("Atacará primero jugador2");
        }
        else if (vel3 > vel1 && vel3 > vel2)
        {
            Debug.Log("Atacará primero jugador3");
        }else
        {
            Debug.Log("Tienes que introducir velocidades con valores diferentes");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
