using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    int min, max, guess;

    public int maxTry = 5;

    public Text guessText;


    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();


    }



    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

        if (maxTry <= 0)
        {
            guessText.text = "GG";
            SceneManager.LoadScene("Win");
        }

        maxTry = maxTry - 1;
        
       


    }

}
