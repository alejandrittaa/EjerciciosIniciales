using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

    [SerializeField] int danhoMax;
    [SerializeField] int danhoMin;
    [SerializeField] int capacidadTotal;
    [SerializeField] bool automatica;
    int municionActual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //no entiendo lo de devolver un 0 o un -1, no se a que te refieres
    void UtilizarArma()
    {
        if(municionActual > 0)
        {
            municionActual -= 1;
            Debug.Log("0");
        }else
        {
            Debug.Log("-1");
        }
    }

    void RecargarArma()
    {
        if (municionActual != capacidadTotal)
        {
            municionActual = capacidadTotal;
            Debug.Log("0");
        }
        else
        {
            Debug.Log("-1");
        }
    }
}
