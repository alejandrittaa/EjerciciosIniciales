using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{

    [SerializeField] int num1;
    [SerializeField] int num2;


    void Start()
    {
        if(num1 > num2)
        {
            while(num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }else if(num2 > num1)
        {
            while (num2 >= num1) 
            {
                Debug.Log(num2);
                num2--;
            }
        }else { Debug.Log("Debes introducir dos números distintos"); }
    }

}
