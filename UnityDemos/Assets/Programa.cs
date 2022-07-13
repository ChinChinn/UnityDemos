using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Programa : MonoBehaviour
{
    //Este es un comentario

    /* Este
    es
    otro
    comentario
    */

    // Tipo de dato + identificador = el valor

    public float num1;
    public float num2;
    
    // Start is called before the first frame update
    void Start()
    {
        float suma = num1 + num2;
                Debug.Log("La suma es: " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Otro mensaje");
    }
}
