using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberGuessingGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        float low = 1,
            high = 100,
            guessedNumber = 0,
            secretNumber = 15,
            guesses = 0;

        while (guessedNumber != secretNumber)
        {
            guessedNumber = Random.Range(low, high);
            if(guessedNumber <secretNumber)
            {
                low = guessedNumber;
            }
            if(guessedNumber > secretNumber)
            {
                high = guessedNumber;
            }
            guesses++;

        }
        if(guessedNumber == secretNumber)
        {
            print("secret number is " + secretNumber + " and it took me " + guesses + " trys to guess it");
        }

    }


}
