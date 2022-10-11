using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     This is a multiline comment:
     4 variables with the player information
     */
    public int playerAge = 33;
    public string playerName = "emesefe";
    private float playerSpeed = 3.125f;
    [SerializeField] private bool isGameOver = false;

    public string message = "Hola mundo.";
    public int points = 256;
    
    private void Start()
    {
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");
        
        Debug.Log($"Hola {playerName}, tienes {points} puntos");
        
        Debug.Log(string.Format(
            "Tengo {0} puntos", points));
        
        Debug.Log(string.Format(
            "Hola {0}, tienes {1} puntos", 
            playerName, points));
        
        Debug.Log("Tengo " + points + " puntos");
    }
}
    
