using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour
{
    public string myName = "Keith"; // string to hold my name
    public string myLastName = "Marshall";//string to hold my last name
    public int MyAgeInYears = 43; // an int to hold my age in years
    public int myAgeInMonths = 0; // an int to hold my age in months
    public int myAgeInWeeks = 0; // an int to hold my age in weeks


    private void Akwake() // a function that gets called before the start function
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        printFulName();
        printMyAge(MyAgeInYears);
    }

    // Update is called once per frame
    void Update()
    {
        printMyClassTime(); // this will be called on every frame
    }
    public void printFulName() // a function that stores my name in full
    {
        Debug.Log("My name is" + myName + " " + myLastName); // debug log that stores the calculation 
    }
    public void printMyAge(int MyAgeInYears) // a functiuon that prints my age
    {

        int monthsInAYear = 12; // a tempurary int to store months in a year
        int weeksInAMonth = 4; // a tempurary int  to store weeks in a month
        int daysInWeek = 7; // a tempurary int to store days in a week
        int myAgeInDays = 0; // a tempurary int to store my age in years

        myAgeInMonths = MyAgeInYears * monthsInAYear; // calculation for my age in months
        myAgeInWeeks = myAgeInMonths * weeksInAMonth; // calculation for my age in weeks
        myAgeInDays = myAgeInWeeks * daysInWeek; // calculation for my age in days

        // debug log to store my print my age function
        Debug.Log(" My age in years is: " + MyAgeInYears + " Years old, which is " + myAgeInMonths + " in months, which is " + myAgeInWeeks + " in weeks, which is " + myAgeInDays + " in days.");

    }
    public void printMyClassTime()
    {
        Debug.Log("My Class Time Is On Thursdays at 15.30. ");
    }
}
