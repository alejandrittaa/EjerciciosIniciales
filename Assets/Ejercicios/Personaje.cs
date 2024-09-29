using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre = "";
    private int vida;
    private int experiencia;
    [SerializeField] Personaje Enemigo;
    [SerializeField] SistemaDeVida MiSistemaDeVidas;
    [SerializeField] Arma MiArma;
    [SerializeField] KeyCode Cura;
    [SerializeField] KeyCode HacerDanho;
    [SerializeField] KeyCode Recarga;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Experiencia { get => experiencia; set => experiencia = value; }
    public int Vida { get => vida; set => vida = value; }

    //no acabo de entender nada a partir del 8_4 la verdad

    void Start()
    {
        if(Input.GetKeyDown(Cura))
        {
            //RecibirCura();
            //como no se que falla en el script de sistemadevida, tengo que comentarlo para poder hacer el resto de cosas.
        }else if (Input.GetKeyDown(HacerDanho))
        {
            //UtilizarArma();
            //Enemigo.RecibirDanho();
            //como no se que falla en el script de sistemadevida, tengo que comentarlo para poder hacer el resto de cosas.
        }else if (Input.GetKeyDown(Recarga))
        {
            //MiArma.RecargarArrma();
        }
    }

    
    void Update()
    {
        
    }

    public float CalcularNivel()
    {
        int nivel = experiencia / 1000;
        return nivel;
    }
}
