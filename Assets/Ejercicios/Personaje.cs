using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre = "";
    private int vida;
    private int experiencia;
    [SerializeField] Personaje enemigo;
    [SerializeField] SistemaDeVida MiSistemaDeVidas;
    [SerializeField] Arma MiArma;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Experiencia { get => experiencia; set => experiencia = value; }
    public int Vida { get => vida; set => vida = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalcularNivel()
    {
        int nivel = experiencia / 1000;
        return nivel;
    }
}
