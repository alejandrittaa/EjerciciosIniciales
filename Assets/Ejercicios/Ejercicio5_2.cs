using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;

    void Start()
    {
        if (num1 <= 3 && num2 <= 3)
        {
            Debug.Log("Ambos números son menores de 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
