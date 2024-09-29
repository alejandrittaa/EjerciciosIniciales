using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BatallaPVP : MonoBehaviour
{
    PersonajePVP player1;
    PersonajePVP player2;
    PersonajePVP player3;
    PersonajePVP player4;
    PersonajePVP combatiente1;
    PersonajePVP combatiente2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarCombatientes()
    {
        //no entiendo porq no va el random
        player1.RellenarStats(Random.Range(50f, 120f), Random.Range(20f, 100f), Random.Range(50f, 200f)); 
        player2.RellenarStats(Random.Range(50f, 120f), Random.Range(20f, 100f), Random.Range(50f, 200f)); 
        player3.RellenarStats(Random.Range(50f, 120f), Random.Range(20f, 100f), Random.Range(50f, 200f)); 
        player4.RellenarStats(Random.Range(50f, 120f), Random.Range(20f, 100f), Random.Range(50f, 200f));
    }

    void CrearEmparejamiento()
    {

    }

    void GenerarCombate()
    {

    }
}
