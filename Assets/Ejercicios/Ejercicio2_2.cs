using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_2 : MonoBehaviour
{

    int vidas = 10;
    float exp = 2.5f;
    char carac = 'A';
    float resultadoSuma;
    float resultadoResta;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tienes " + vidas + " vidas y " + exp + " de experiencia.");
        resultadoSuma = vidas + exp;
        Debug.Log("Si sumas tus vidas y tu experiencia, tendrás " + resultadoSuma );
        resultadoResta = vidas - exp;
        Debug.Log("Si restas tus vidas y tu experiencia, tendrás " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
