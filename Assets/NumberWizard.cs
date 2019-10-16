using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int minNumber = 1;
    private int maxNumber = 1000;
    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        guess = average(minNumber, maxNumber);
        introText();
        guessText();
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

    void introText()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number");
        Debug.Log($"Maximum of {maxNumber}");
        Debug.Log($"Minimum of {minNumber}");
    }

    void guessHigher()
    {
        minNumber = guess;
        guess = average(minNumber, maxNumber);
        guessText();
    }

    void guessLower()
    {
        maxNumber = guess;
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
        Application.Quit();
    }
}
