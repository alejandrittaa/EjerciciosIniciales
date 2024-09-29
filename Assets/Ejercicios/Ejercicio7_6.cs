using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{

    [SerializeField] int numpositivo;
    [SerializeField] int numnegativo;

    // Start is called before the first frame update
    void Start()
    {
        //CON WHILE
        /*
        while(numpositivo >= numnegativo)
        {
            Debug.Log(numpositivo);
            numpositivo--;
        }
        */


        //CON FOR
        
        for (int i = numpositivo; i >= numnegativo; i--)
        {
            Debug.Log(i);
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
