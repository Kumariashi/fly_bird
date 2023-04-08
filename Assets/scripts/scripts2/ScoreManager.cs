using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public QuitScript QuitScript;

    public void Player1Goal()
    {
        player1Score++;
        if (player1Score >= 3)  //6
            QuitScript.GoToNextLevel();


        // Change the text on the text component.
        player1ScoreText.text = player1Score.ToString();
       

    }



    public void Player2Goal()
    {
        player2Score++;
        if (player2Score >= 3)  //6
            QuitScript.GoToNextLevel();


        // Change the text on the text component.
        player2ScoreText.text = player2Score.ToString();

    }
    
}




   
