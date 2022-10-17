using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int wheels = 4;
    [SerializeField] private string name;

    private void Start()
    {
        // Forma 1
        Debug.Log($"El vehículo {name} tiene {wheels} ruedas.");
        // Forma 2
        Debug.Log(string.Format("El vehículo {0} tiene {1} ruedas.", name, wheels));
        // Forma 3
        Debug.Log("El vehículo " + name + " tiene " + wheels + " ruedas");
    }
}
