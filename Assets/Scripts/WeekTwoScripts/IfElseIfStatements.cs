using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseIfStatements : MonoBehaviour
{
    public string myName = "Keith"; // A string to hold my name
    public string myMotorcycleColour = "white"; // A string to hold motorcycle colour
    public bool likesCoffee = true; // A bool to see if i like coffee
    public int myAge = 43; // a int to hold my age

    // Start is called before the first frame update
    void Start()
    {
        // checks to see if like coffee is true then debug.log out your addicted to coffee
        if (likesCoffee == true)
        {
            Debug.Log("Your addicted to coffee");
        }
        // checks if age is greater than 43 if true debugs.logs out your age is greater than 43
        if (myAge > 43)
        {
            Debug.Log("Your age is greater than 43");
        }
        // else if it will debug this line 
        else if( myAge < 43)
        {
            Debug.Log("You are younger than 43");
        }
        if(myMotorcycleColour == "white")
        {
            Debug.Log("Your motorcycle is white");

                }
        else if ( myMotorcycleColour == "Red")
        {
            Debug.Log(" Your motorcycle is red must be really fast then");
            if(likesCoffee == false)
            {
                Debug.Log(" you hate coffee");
            }
        }
        else
        {
            if(myMotorcycleColour == "yellow")
            {
                Debug.Log("You love bright colours");
            }
            else
            {
                Debug.Log("Your Motorcycle colour is not yellow then");
            }
        }
    }
 }

        
    


        
    

