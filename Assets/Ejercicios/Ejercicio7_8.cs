using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{

    [SerializeField] int num1;
    [SerializeField] int num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 % 2 == 0)
        {
            for (int i = num1; i >= num2; i = i -2)
            {
                Debug.Log(i);
            }
        }
        else if (num2 > num1 && num2 % 2 == 0)
        {
            for (int i = num2; i >= num1; i = i - 2)
            {
                Debug.Log(i);
            }
        }else if(num1 > num2 && num1 % 2 != 0)
        {
            for (int i = num1 + 1; i >= num2; i = i - 2)
            {
                Debug.Log(i);
            }
        }
        else if (num2 > num1 && num2 % 2 != 0)
        {
            for (int i = num2 + 1; i >= num1; i = i - 2)
            {
                Debug.Log(i);
            }
        }
        else { Debug.Log("Debes introducir dos números distintos"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
