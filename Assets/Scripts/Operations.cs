using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using UnityEngine;

public class Operations : MonoBehaviour
{
    
    public float x;
    public float y;

    /*
    public int xInt;
    public int yInt;
    */

    private void Start()
    {
        /*
        Debug.Log($"Sum: {x} + {y} = {x + y}");
        Debug.Log($"Subtraction: {x} - {y} = {x - y}");
        Debug.Log($"Product: {x} * {y} = {x * y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
        Debug.Log($"Module: {xInt} % {yInt} = {xInt % yInt}");
        */
        Calculator(x, y);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Calculator(x, y);
        }
    }

    private void Calculator(float num1, float num2)
    {
        Debug.Log($"Sum: {num1} + {num2} = {num1 + num2}");
        Debug.Log($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Debug.Log($"Product: {num1} * {num2} = {num1 * num2}");
        Debug.Log($"Division: {num1} / {num2} = {num1 / num2}");
    }

}
