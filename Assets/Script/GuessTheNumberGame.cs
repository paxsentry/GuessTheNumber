using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour
{
    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int usersGuess;

    // Use this for initialization
    void Start()
    {
        guessNumber = Random.Range(0, 100);
    }

    public void CheckGuess()
    {
        usersGuess = int.Parse(input.text);

        if (usersGuess == guessNumber)
        {
            infoText.text = "You guessed rigth the number! Great!";
        }
        else if (usersGuess > guessNumber)
        {
            infoText.text = "Your number is greater than the guess number.";
        }
        else if (usersGuess < guessNumber)
        {
            infoText.text = "You number is lower than the guess number.";
        }

        input.text = "";
    }
}