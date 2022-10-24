using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Ejercicio: Crea variables
    [SerializeField] private int wheels = 4; //Number of wheels of the vehicle
    
    // Ejercicio: Muestra variables I
    [SerializeField] private string name;
    
    // Ejercicio: Arrancar el vehículo
    [SerializeField] private bool isOn;

    private void Start()
    {
        // Ejercicio: Muestra variables II
        // Forma 1
        Debug.Log($"El vehículo {name} tiene {wheels} ruedas.");
        // Forma 2
        Debug.Log(string.Format("El vehículo {0} tiene {1} ruedas.", name, wheels));
        // Forma 3
        Debug.Log("El vehículo " + name + " tiene " + wheels + " ruedas");
        
        
        // Ejercicio: Arrancar el vehículo
        if (isOn == true)
        {
            Debug.Log($"El vechículo {name} está encendido");
        }

        if (isOn == false)
        {
            Debug.Log($"El vechículo {name} está apagado");
        }
    }
}
