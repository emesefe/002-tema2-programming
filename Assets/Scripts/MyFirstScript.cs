using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     This is a multiline comment:
     4 variables with the player information
     */
    
    // This variable saves the player's age
    public int playerAge = 33;
    // This variable saves the player's username
    public string playerName = "emesefe";
    
    // This variable saves the player's speed
    private float playerSpeed = 3.125f;
    // This variable saves if the player has lost
    [SerializeField] private bool isGameOver = false;
}
    

