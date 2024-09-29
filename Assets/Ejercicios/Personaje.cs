using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre = "";
    private int vida;
    private int experiencia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float CalcularNivel()
    {
        int nivel = experiencia / 1000;
        return nivel;
    }
}
