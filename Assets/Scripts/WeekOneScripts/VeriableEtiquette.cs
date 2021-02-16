using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// A script that shows the correct setup and usage of veriables inside unity
/// </summary>
public class VeriableEtiquette : MonoBehaviour
{
  // access type , the data type, variable name, default value.
    public int myFirstInt = 8; // An int stores whole numbers!
    private int mySecondInt = 2;
    public float myFirstFloat = 3.45f; // A float stores decimal numbers must have a f at the end to know its a float!
    public double myFirstDouble = 2.34f; // Is the same as a float but can store up to 16 decimal numbers must use a f to Know its a double!
    public bool myFirstBool = true; // Holds true or false statements!
    public string myFirstString = "Keith is the man"; // Stores whole words must use "" to Know its a string
    public char myFristChar = 'n'; // holds single charecters must use single '' to know its a char 

        //first frame update
    void Start()
    {
        myFirstString = "keith always is on time"; // sets first string to keith always is on time

        myFirstInt = 10; // sets first int to 10
    }        
    }

