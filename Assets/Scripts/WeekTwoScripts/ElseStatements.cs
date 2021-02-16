using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseStatements : MonoBehaviour
{
    public string myName = "keith"; // a string that holds my name
    public string motorcycleColour = "white"; // a string that holds motorcycle colour
    public bool likesCoffee = true; // a bool that to see if likes coffee 
    public int myAge = 43; // an int to hold my age
    // Start is called before the first frame update
    void Start()
    {
        if(myName == "keith") // if statement to check if name dose equel to keith
        {
            Debug.Log("Your name is keith"); // debug logs out your name is keith if if statement is correct.
        }
        else // an else statement if the if statement returns a false value the else will be exacuted
        {
            Debug.Log("Your not keith why are you here?");
        }
        // an example of nesting an else statement with in a an if nesting statement.
        if(myName != "keith" || motorcycleColour == "white")
        {
            Debug.Log("your are not keith or your motorcycle colour is white");
            if(likesCoffee == true)
            {
                Debug.Log("likes coffee");
            }
            else
            {
                Debug.Log("Dose not like coffee");
                if (myAge > 43)
                {
                    Debug.Log("you are older than keith");
                }
                else
                {
                    Debug.Log("you are younger than keith");
                   
                }
            }
        }
    }
}
