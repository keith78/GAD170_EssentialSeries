using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeDiceRolling : MonoBehaviour
{
    public int myDiceRoll = 0; // an int to store dice roll
    public int myMinDiceRoll = 0; // an int to store minimum dice roll
    public int myMaxDiceRoll = 6; // an into to stor max dice roll

    [Tooltip("The key used to roll the dice")]
    public KeyCode rollInputKey; // the key to use to roll the dice
    // Start is called before the first frame update
    void Start()
    {
        // an example of scope this veriable myCurrentDiceRoll is only vuable in the start function.
        // if you try view it outside of the current{} you will not be able to access it.
        int myCurrentDiceRoll = 0;
        if(myCurrentDiceRoll > 0)
        {
            myCurrentDiceRoll = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(rollInputKey))
        {
            // create a tempurary Variable for my current dice roll
            int myCurrentDiceRoll = Random.Range(myMinDiceRoll, myMaxDiceRoll + 1);
            myDiceRoll = myCurrentDiceRoll;

            Debug.Log("My Dice Roll is; " + myDiceRoll);

            Debug.Log("The Percentage chance of getting this number is: " + (1f / 6f) + "%"); // Adds Debug.Log of percentage chance of getting that roll

            // debug.log out the result of the dice roll
            if(myDiceRoll < 3)
            {
                Debug.Log("Dice roll is less than 3");
            }
            else if(myDiceRoll > 3 && myDiceRoll <5)
            {
                Debug.Log("Dice roll is greater than three and less than five");
            }
            else
            {
                Debug.Log(" Your number is 6");
            }
        }
    }
}
