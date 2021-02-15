using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commenting : MonoBehaviour
{
    // This is a single line comment!

    /// <summary>
    /// myFirstBool is a bool that is my first
    /// </summary>
    [Tooltip("A bool used for my first")] 
    public bool myFirstBool = true; // public bool holds true or false statements

    [Header("The cool guy")]
    public string myFirstString = "Keith"; // public string holds words between ""!

    [Space(10)]
    public int myFirstInt = 1; // public int holds whole numbers
    /* this is a multiline comment!
     * you will notice when i press enter i get a new line and keep commenting!
     */
    #region  Functions - holds all the functions for my game
    /// <summary>
    /// This is the start function it is called on the first frame of the game!
    /// </summary
    void Start()
    {
        myFirstBool = false;
    }
    #endregion 
}

