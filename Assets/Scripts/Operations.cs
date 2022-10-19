using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x;
    public float y;

    public int xInt;
    public int yInt;

    private void Start()
    {
        Debug.Log($"Sum: {x} + {y} = {x + y}");
        Debug.Log($"Subtraction: {x} - {y} = {x - y}");
        Debug.Log($"Product: {x} * {y} = {x * y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
        Debug.Log($"Module: {xInt} % {yInt} = {xInt % yInt}");
    }
}
