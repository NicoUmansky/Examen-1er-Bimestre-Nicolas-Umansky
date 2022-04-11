using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public string monedaextranjera;
    public float montoconvertir;
    void Start()
    {
        if (montoconvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else if (monedaextranjera == "D")
        {
            Debug.Log("$" + montoconvertir + " pesos argentinos equivalen a " + montoconvertir / 112 + " dolares");
        }
        else if (monedaextranjera == "R")
        {
            Debug.Log("$" + montoconvertir + " pesos argentinos equivalen a " + montoconvertir / 23 + " reales");
        }
        else if (monedaextranjera == "E")
        {
            Debug.Log("$" + montoconvertir + " pesos argentinos equivalen a " + montoconvertir / 122 + " euros");
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
        }

    }


}
