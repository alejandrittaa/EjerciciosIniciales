using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{

    [SerializeField] int tipo;

    // Start is called before the first frame update
    void Start()
    {
        if(tipo == 1)
        {
            Debug.Log("El enemigo 1, tiene 350 de DA�O, y 650 de VIDA");
        }else if(tipo == 2)
        {
            Debug.Log("El enemigo 2, tiene 300 de DA�O, y 550 de VIDA");
        }
        else if(tipo == 3)
        {
            Debug.Log("El enemigo 3, tiene 300 de DA�O, y 500 de VIDA");
        }
        else if(tipo == 4)
        {
            Debug.Log("El enemigo 4, tiene 310 de DA�O, y 460 de VIDA");
        }
        else if(tipo == 5)
        {
            Debug.Log("El enemigo 5, tiene 280 de DA�O, y 490 de VIDA");
        }
        else  if(tipo == 6)
        {
            Debug.Log("El enemigo 6, tiene 360 de DA�O, y 520 de VIDA");
        }
        else
        {
            Debug.Log("El tipo introducido es inv�lido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
