using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
    public string myName = "Keith"; // string to hold my name
    public string myLastName = "Marshall";//string to hold my last name
    public int MyAgeInYears = 43; // an int to hold my age in years
    public int myAgeInMonths = 0; // an int to hold my age in months
    public int myAgeInWeeks = 0; // an int to hold my age in weeks

    public bool isGamePaused = false; // a bool to hold if the game is paused

    private void Akwake() // a function that gets called before the start function
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        // An example of how to call a function with parameters.
        PrintMyFullName(myName, myLastName);
        // An example of using an optional parameter
        PrintMyFullName("Nathan", "Jensen");
        PrintMyAge(MyAgeInYears);
    }

    // Update is called once per frame
    void Update()
    {
        // checks to see if the game is paused
        if(isGamePaused == true)
        {
            return; 
        }
        PrintMyClassTime(); // this will be called on every frame
    }
    public void PrintMyFullName(string FirstName, string LastName, int MyAge = -1) // a function that stores my name in full
    {
        string fullName = ReturnFullName(FirstName,LastName); 
      if(!IsMyNameEqual(FirstName, "Keith"))
        {
            Debug.Log("Hey your not Keith");
            return;
        }
        Debug.Log("My Name Is: " + ReturnFullName(FirstName, LastName));
        // checks to ee if age is greater than 0
        if(MyAge > 0)
        {
            // Functions can be called inside other functions
            PrintMyAge(MyAge);

            PrintMyAge(MyAge - 10);

        }
    }
    public string ReturnFullName (string Firstname, string LastName)
    {
        return Firstname + " " + LastName;
    }
    //The anatomy of a function is as follows:
    // Access Type : public or private.
    //The Return Type: Void + returns nothing, just do instructions
    //the function name, the same naming scheme as a class all capital letters for all the first letters of the word.
    //Finally our paranethese and curly braces with instructions inside. (){}
    //Inside a parenetheses () I can declare temporary veriables, which can store sata from when the function is called.
    //This allows me to resuse the function more effectively.
    // When use the = sign we can set a default value for our parameters,  just make sure they are at the end of the parameter list.
    public void PrintMyAge(int MyAgeInYears) // a functiuon that prints my age
    {

        int monthsInAYear = 12; // a tempurary int to store months in a year
        int weeksInAMonth = 4; // a tempurary int  to store weeks in a month
        int daysInWeek = 7; // a tempurary int to store days in a week
        int myAgeInDays = 0; // a tempurary int to store my age in years

        // here you will notice i am using the functions parameter rather than the public verable at the top
        // this allows me to use what ever value i store inside the parameter making the code more reusable 
        myAgeInMonths = ReturnProductOfTwoNumber(MyAgeInYears, monthsInAYear); // calculation for my age in months
        myAgeInWeeks = ReturnProductOfTwoNumber(myAgeInMonths, weeksInAMonth);  // calculation for my age in weeks
        myAgeInDays = ReturnProductOfTwoNumber(myAgeInWeeks, daysInWeek); // calculation for my age in days

        // debug log to store my print my age function
        Debug.Log(" My age in years is: " + MyAgeInYears + " Years old, which is " + myAgeInMonths + " in months, which is " + myAgeInWeeks + " in weeks, which is " + myAgeInDays + " in days.");

    }
    public bool IsMyNameEqual(string Name, string NameToCheck)
    {
        if(Name == NameToCheck)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private int ReturnProductOfTwoNumber (int FirstNumber, int SecondNumber)
    {
        Debug.Log("First Number is: " + FirstNumber);

        return FirstNumber * SecondNumber;
    }
    public void PrintMyClassTime()
    {
        Debug.Log("My Class Time Is On Thursdays at 15.30. ");
    }
}