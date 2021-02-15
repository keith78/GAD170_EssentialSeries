using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperandsTutorial : MonoBehaviour
{
    public string myName = "keith"; // string that holds my name.
    public int myAgeInYears = 43; // An int that holds my age in years.
    public int myAgeInMonths = 0; // An int that holds my age in months.
    public int myAgeInWeeks = 0; // An int that holds my age in week.
    public int myAgeInDays = 0; // An int that holds my age in days.
    public int myBirthdayDay = 05; // An int that holds my birthday day.
    public int myBirthdayMonth = 04; // An int that holds my birthday month,
    public int myBirthdayYear = 1978; // An in that holds my birthday year.
    // Start is called before the first frame update
    void Start()
    {
        string myDebugMessage = " My Name is: " + myName + " My birhday is: " + myBirthdayDay + "/" + myBirthdayMonth + "/" + myBirthdayYear;
        myDebugMessage = myDebugMessage + " My age in years is: " + myAgeInYears;

        myAgeInMonths = myAgeInYears * 12;
        Debug.Log("My age in months is: " + myAgeInMonths);
        myAgeInWeeks = myAgeInMonths * 4;
        Debug.Log(" My age in weeks is: " + myAgeInWeeks);
        myAgeInDays = myAgeInWeeks * 7;
        Debug.Log(" My age in days is: " + myAgeInDays);

        myDebugMessage += " My age in months is: " + myAgeInMonths;
        myDebugMessage += " My age in weeks is: " + myAgeInWeeks;
        myDebugMessage += " My age in days is " + myAgeInDays;

        Debug.Log(myDebugMessage);

        Debug.Log("This is an example of modulos, it devides a number evenly and returns the remainder which is: " + myAgeInDays % 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
