using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{

    int p1 = 10;
    int p2 = 5;
    int p3 = 20;
    float media = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        media = ((p1 + p2 + p3) / 3);
        Debug.Log("Tus puntuaciones son: " + p1 + " " + p2 + " " + p3 + " y la media de estas es " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
