using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugingExample : MonoBehaviour
{
    public string myName = "Keith";
    public int myAge = 43;
    public bool myFirstBool = false;
    public int myAgeInMonths = 0;
       
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log logs out a string we put inside of it.
        // We can add multiple strings and veriables together to make a big string.
        //Debugging is super usefull for when we want to break down our code and check for bugs and where there accuring.
        Debug.Log(myName);
        Debug.Log(myAge);
        Debug.Log(myFirstBool);
        Debug.Log(myAgeInMonths);
        Debug.Log(myName + "is this many years old:" + myAge);

        myAgeInMonths = myAge * 12;
        //This is an example of adding strings and veriables together to make a string to log out.
        Debug.Log("My age in months:" + myAgeInMonths);

        // This will pause the editor, allowing us to check scripts during runtime in our inspector.
        Debug.Break();

        // Logs out and error message, if the console has a pause on error the inspector will pause.
        Debug.LogError("There has been an error:0");
        // Logs out a warning, will not pause the editor will just show a warning message.
        Debug.LogWarning("This is just a warning");
    }

    // Update is called once per frame
    void Update()
    {
        myAgeInMonths = 23;
        //This will be called everyframe and is an example of how to check veriables that are set later in our code.
        Debug.Log("Age in months is now:" + myAgeInMonths);
    }
}
