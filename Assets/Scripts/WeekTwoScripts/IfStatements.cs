using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public string myName = "Keith"; // A veriable to hold my name.
    public bool likesCoffee = true; // Does the user like coffee
    public int myFavouriteNumber = 7; // A veriable to hold favourite number
    public float myFavouriteFloat = 5.5f; // A veriable to hold favourite float.

    // Start is called before the first frame update
    void Start()
    {
        // An example of an if statement if the conditions of the if statement are true it 
        // will exacute the line of code bellow it 
        if (likesCoffee == true)
        {
            // If the conditions of the if statement == true it will exacute this Debug.log
            Debug.Log("Keith just Loves Coffee");
        }
        // An example of a false if statement if the conditions of a false statment is true it will exacute the line of code bellow it
        if (likesCoffee == false)
        {
            // if the conditions of the if stament == false it will exacute this Debug.Log
            Debug.Log("You dislike coffee you are an imposter");
        }
        if (myName == "Nathan")
        {
            Debug.Log("Hi Nathan has Keith gotten you to do his work again?");
        }
        // this is a example of a string if statement != stands for does not equel to
        if (myName != "Nathan")
        {
            // if myName does not equel to Nathen it will exacute this line of code
            Debug.Log("Oh hi Keith good to see you back again");
            likesCoffee = true;
        }
        if (myFavouriteNumber == 7)
        {
            Debug.Log("thats right your favorite number is 7");
        }
        if (myFavouriteNumber < 7)
        {
            Debug.Log("Your trying to confuse me Naughty boy!!");
        }
        // Examples of multiple conditions
        // an example of a && (and) bothe conditions must match for the if statement to exacute the code
        if (myName == "Keith" && likesCoffee == false)
        {
            Debug.Log("Yes you do like coffee well you used to maybe your confusing me?");
        }
        if (myName != "Keith" && likesCoffee == false)
        {
            Debug.Log("Your a hacker, im beings hacked just great NOT!!");
        }
        // An example of || (or) if  one of the conditions are meet it will exacute the code
        if (myFavouriteNumber < 3 || myFavouriteNumber > 7)
        {
            Debug.Log("Incorect password");
        }
        // An example of nesting multiple if satements.
        if (likesCoffee == true)
        {
            if (myName == "Keith")
            {
                Debug.Log("Keith likes coffee");
            }
            if (myName != "Keith")
            {
                Debug.Log("Keith likes coffee");
                if (myFavouriteNumber > 4 && myFavouriteNumber < 7)
                {
                    Debug.Log("And my favourite number is: " + myFavouriteNumber);
                }



            }
        }
    }
}

