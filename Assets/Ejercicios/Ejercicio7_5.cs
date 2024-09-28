using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{

    [SerializeField] int num;

    // Start is called before the first frame update
    void Start()
    {
        //CON WHILE 
        while(num > 0)
        {
            Debug.Log(num);
            num--;
        }

        /*for (int i = 1; i < num; i++) 
        { 
            Debug.Log(num);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
