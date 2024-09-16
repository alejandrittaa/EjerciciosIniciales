using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{

    int vidasPlayer1 = 10;
    int vidasPlayer2 = 5;
    int vidasPlayer3 = 32;
    int vidasPlayer4 = 100;
    int ividasPlayer2 = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidasPlayer2 = vidasPlayer3);
        Debug.Log(vidasPlayer3 = vidasPlayer1);
        Debug.Log(vidasPlayer1 = vidasPlayer4);
        Debug.Log(vidasPlayer4 = ividasPlayer2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
