using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{

    [SerializeField] float vidaInicial;
    float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float RecibirCura(float cantidad)
    { 
        if(cantidad > 0)
        {
            vidaActual = vidaInicial + cantidad;
            return vidaActual;
        }else
        {
            Debug.Log("No puede recibir una cantidad de cura negativa");
        }

    }
    float RecibirDanho(float danho)
    {
        if (danho > 0)
        {
            vidaActual = vidaInicial - danho;
            return vidaActual;
        }
        else
        {
            Debug.Log("No puede recibir una cantidad de daño negativa");
        }
        
    }
}
