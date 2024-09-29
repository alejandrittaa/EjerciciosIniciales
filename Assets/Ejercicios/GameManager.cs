using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje sonic;
    [SerializeField] Personaje mario;
    bool ejecutado;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(ejecutado == false)
            {
                PrepararPersonajes();
            }
            else
            {
                Debug.Log("El método ya se ha ejecutado");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrepararPersonajes()
    {
        sonic.Vida = 100;
        mario.Vida = 200;
        sonic.Nombre = "Sonic";
        mario.Nombre = "Mario";
        Debug.Log(sonic.CalcularNivel());
        Debug.Log(mario.CalcularNivel());
        ejecutado = true;
    }

    //no entiendo nada más allá del ejercicio 8_4
    void FinDeTurno()
    {
        
    }
}
