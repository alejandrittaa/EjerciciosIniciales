using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{

    [SerializeField] float velocidadkm;
    float velocidadm;

    // Start is called before the first frame update
    void Start()
    {
        velocidadm = velocidadkm * 1000;
        Debug.Log("La velocidad en m/s es de " + velocidadm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
