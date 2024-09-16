using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{

    int oro = 7;

    // Start is called before the first frame update
    void Start()
    {
        oro = oro * 14400;
        Debug.Log("En 4 horas, habrás farmeado " + oro + " de oro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
