using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{

    [SerializeField] int num;
    int doble;
    int triple;

    // Start is called before the first frame update
    void Start()
    {
        doble = num * 2;
        triple = num * 3;
        Debug.Log("El doble del número que has introducido es " + doble + " y el triple es " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
