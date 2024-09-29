using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2)
        {
            while (num1 >= num2)
            {
                if(num1 % 2 == 0 && num1 >= 0)
                {
                    Debug.Log(num1 + "es par y positivo");
                }else if (num1 % 2 == 0 && num1 <= 0)
                {
                    Debug.Log(num1 + "es par y negativo");
                }else if (num1 % 2 != 0 && num1 >= 0)
                {
                    Debug.Log(num1 + "es impar y positivo");
                }
                else if (num1 % 2 != 0 && num1 <= 0)
                {
                    Debug.Log(num1 + "es impar y negativo");
                }
                num1--;
            }
        }
        else if (num2 > num1)
        {
            while (num2 >= num1)
            {
                if (num2 % 2 == 0 && num2 >= 0)
                {
                    Debug.Log(num2 + "es par y positivo");
                }
                else if (num2 % 2 == 0 && num2 <= 0)
                {   
                    Debug.Log(num2 + "es par y negativo");
                }
                else if (num2 % 2 != 0 && num2 >= 0)
                {
                    Debug.Log(num2 + "es impar y positivo");
                }
                else if (num2 % 2 != 0 && num2 <= 0)
                {
                    Debug.Log(num2 + "es impar y negativo");
                }
                num2--;
            }
        }
        else { Debug.Log("Debes introducir dos números distintos"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
