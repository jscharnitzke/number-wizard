using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    const int INIT_MIN = 1;
    const int INIT_MAX = 1000;

    private int minNumber;
    private int maxNumber;
    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            guessHigher();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            guessLower();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameOver();
        }
    }

    void initialize()
    {
        minNumber = INIT_MIN;
        maxNumber = INIT_MAX;
        guess = average(minNumber, maxNumber);
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log($"Pick a number between {minNumber} and {maxNumber}.");
        guessText();
    }

    void guessHigher()
    {
        minNumber = guess;
        nextGuess();
    }

    void guessLower()
    {
        maxNumber = guess;
        nextGuess();
    }

    void nextGuess()
    {
        guess = average(minNumber, maxNumber);
        guessText();
    }

    void guessText()
    {
        Debug.Log($"Is your number {guess}?");
        Debug.Log("<Up> = Higher, <Down> = Lower, <Enter> = Correct");
    }

    int average(int a, int b)
    {
        return (a + b) / 2;
    }

    void gameOver()
    {
        Debug.Log($"Your number was {guess}");
        initialize();
    }
}
