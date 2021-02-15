using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperandsTutorial : MonoBehaviour
{
    public string myName = "keith"; // string that holds my name.
    public int myAgeInYears = 43; // An int that holds my age in years.
    private int myAgeInMonths = 0; // An int that holds my age in months.
    private int myAgeInWeeks = 0; // An int that holds my age in week.
    private int myAgeInDays = 0; // An int that holds my age in days.
    public int myBirthdayDay = 05; // An int that holds my birthday day.
    public int myBirthdayMonth = 04; // An int that holds my birthday month,
    public int myBirthdayYear = 1978; // An in that holds my birthday year.
    // Start is called before the first frame update
    void Start()
    {
        // a temporary string to hold my debug message
        string myDebugMessage = " My Name is: " + myName + " My birhday is: " + myBirthdayDay + "/" + myBirthdayMonth + "/" + myBirthdayYear;
        myDebugMessage = myDebugMessage + " My age in years is: " + myAgeInYears;

        //  An example of the * multiplication operand, can also use +,-,/
        myAgeInMonths = myAgeInYears * 12;
        //Debugging out my progress to check it's working.
        Debug.Log("My age in months is: " + myAgeInMonths);
        myAgeInWeeks = myAgeInMonths * 4;
        Debug.Log(" My age in weeks is: " + myAgeInWeeks);
        myAgeInDays = myAgeInWeeks * 7;
        Debug.Log(" My age in days is: " + myAgeInDays);

        //This is an example of a short cut rather than saying myDebugMessage = myDebugMessage i can just sau myDebugMessage += "some new message
        myDebugMessage += " My age in months is: " + myAgeInMonths;
        myDebugMessage += " My age in weeks is: " + myAgeInWeeks;
        myDebugMessage += " My age in days is " + myAgeInDays;

        Debug.Log(myDebugMessage);

        //This is an example of modulos it devides the number on the left by the right and returns the remainder.
        Debug.Log("This is an example of modulos, it devides a number evenly and returns the remainder which is: " + myAgeInDays % 5);
    }    
    }

