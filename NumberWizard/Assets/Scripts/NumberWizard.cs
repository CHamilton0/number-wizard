using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Guess a number between " + min + " and " + max);
        Debug.Log("Is your number higher or lower than: " + guess);
        Debug.Log("Push Up for Higher, Down for lower or Enter for correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Yay, restarting");
            Start();
        }
    }
}
