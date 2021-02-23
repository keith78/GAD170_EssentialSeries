using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionBasics : MonoBehaviour
{
    public string myName = "Keith"; // string to hold my name
    public string myLastName = "Marshall";//string to hold my last name
    public int myAgeInYears = 43; // an int to hold my age in years
    public int myAgeInMonths = 0; // an int to hold my age in months
    public int myAgeInWeeks = 0; // an int to hold my age in weeks


    private void Akwake () // a function that gets called before the start function
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        PrintFulName();
        PrintMyAge();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //The anatomy of a function is as follows:
    // Access Type : public or private.
    //The Return Type: Void + returns nothing, just do instructions
    //the function name, the same naming scheme as a class all capital letters for all the first letters of the word.
    //Finally our paranethese and curly braces with instructions inside. (){}
    public void PrintFulName() // a function that stores my name in full
    {
        Debug.Log("My name is" + myName + " " + myLastName); // debug log that stores the calculation 
    }
public void PrintMyAge() // a functiuon that prints my age
    {

        int monthsInAYear = 12; // a tempurary int to store months in a year
        int weeksInAMonth = 4; // a tempurary int  to store weeks in a month
        int daysInWeek = 7; // a tempurary int to store days in a week
        int myAgeInDays = 0; // a tempurary int to store my age in years

        myAgeInMonths = myAgeInYears * monthsInAYear; // calculation for my age in months
        myAgeInWeeks = myAgeInMonths * weeksInAMonth; // calculation for my age in weeks
        myAgeInDays = myAgeInWeeks * daysInWeek; // calculation for my age in days

        // debug log to store my print my age function
        Debug.Log(" My age in years is: " + myAgeInYears + " Years old, which is " + myAgeInMonths + " in months, which is " + myAgeInWeeks + " in weeks, which is " + myAgeInDays + " in days.");

    }
}
