using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    [Header("Coffee Types")]
    public bool isCappuchino = false;
    public bool isFlatwhite = false;
    public bool isLongBlack = false;

    [Header("Milk Types")]
    public bool isFullCreamMilk = false;
    public bool isLightMilk = false;
    public bool isNoMilk = false;

    [Header("Suger")]
    public int howManySugers = 0;

    public bool hasMilkBeenAsked = false;
    public bool isCoffeeSelected = false; // Is set to true once the user has selected a coffee.
    private bool hasCoffeeBeenAsked = false; // is set to true if coffee has been asked
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCoffeeBeenAsked == false)
        {
            Debug.Log("Welcome to Keith's out of this world cafe extravagnza expreince");
            Debug.Log("I know your here for nothing else but coffee so this is kind of a silly question, but i do have to ask What coffee would you like? \n 1: Cappuchino \n 2: Flat white \n Long Black");
            hasCoffeeBeenAsked = true;
        }
        else if (hasCoffeeBeenAsked == true && isCoffeeSelected == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                isCappuchino = true;
                isFlatwhite = false;
                isLongBlack = false;
                isCoffeeSelected = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                isCappuchino = false;
                isFlatwhite = true;
                isLongBlack = false;
                isCoffeeSelected = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                isCappuchino = false;
                isFlatwhite = false;
                isLongBlack = true;
                isCoffeeSelected = true;
            }
        }
    }
}
