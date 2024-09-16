using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{

    [SerializeField] int exp;
    int lvl;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 32 + (9 * exp / 5);
        Debug.Log("El nivel de tu personaje es de " + lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
