using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    void Start()
    {
        if(nivel % 10 == 0)
        {
            Debug.Log("Tu pokemon ha aprendido un nuevo ataque");
        }
        else
        {
            Debug.Log("Tu pokemon NO ha aprendido un nuevo ataque");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
