using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{

    [SerializeField] int num;
    [SerializeField] int limitemultiplicar;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= limitemultiplicar; i++) 
        { 
            Debug.Log(i + " * " + num + " = " + (i * num));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
