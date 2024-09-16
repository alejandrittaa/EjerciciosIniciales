using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_8 : MonoBehaviour
{

    int vida = 120;
    int vidaveneno1;
    int vidaveneno2;
    int vidaveneno3;
    int vidaveneno4;
    int vidaveneno5;
    int veneno = 3;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Comienzas con " + vida + " de vida");
        vidaveneno1 = vida - ((vida * veneno) / 100);
        Debug.Log("Te han envenenado así que en cada turno perderas un 3% de vida, en este primer turno, te queda " + vidaveneno1 + " de vida");
        veneno += 3;
        vidaveneno2 = vida - ((vida * veneno) / 100);
        Debug.Log("En este segundo turno, te queda " + vidaveneno2 + " de vida");
        veneno += 3;
        vidaveneno3 = vida - ((vida * veneno) / 100);
        Debug.Log("En este tercer turno, te queda " + vidaveneno3 + " de vida");
        veneno += 3;
        vidaveneno4 = vida - ((vida * veneno) / 100);
        Debug.Log("En este cuarto turno, te queda " + vidaveneno4 + " de vida");
        veneno += 3;
        vidaveneno5 = vida - ((vida * veneno) / 100);
        Debug.Log("En este quinto y último turno, te queda " + vidaveneno5 + " de vida");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
