using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer videojuego de Alejandra");
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    //Como bien dice el comentario anterior en inglés, al update se le llama una vez por frame, entonces por cada frame que este el juego en activo, se llamara al update y hará que aparezca el mensaje.
    void Update()
    {
        Debug.Log("Ha pasado un frame");
    }
}
