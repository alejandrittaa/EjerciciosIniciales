using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{

    [SerializeField] int Hora;
    [SerializeField] int Minutos;
    [SerializeField] int Segundos;

    // Start is called before the first frame update
    void Start()
    {
        if(Hora <= 24 && Hora >= 0 && Minutos <= 60 && Minutos >= 0 && Segundos <= 60 && Segundos >= 0)
        {
            Debug.Log("La hora introducida es valida");
        }else
        {
            Debug.Log("La hora introducida NO es valida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
