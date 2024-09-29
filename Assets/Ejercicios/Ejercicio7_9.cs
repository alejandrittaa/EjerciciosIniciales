using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{

    [SerializeField] int num;

    // Start is called before the first frame update
    void Start()
    {
        while(num > 1)
        {
            if(num % 3 == 0)
            {
                Debug.Log(num);
            }
            num--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
