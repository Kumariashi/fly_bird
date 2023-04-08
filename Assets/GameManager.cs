using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle PlayerPaddle;
    public int playerScore;
    public Text playerScoreText;

    public Paddle ComputerPaddle;
    public int computerScore;
    public Text computerScoreText;

   

    public void StartRound()
    {
        PlayerPaddle.ResetPosition();
        ComputerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();

        this.ball.ResetPosition();
        this.PlayerPaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
        this.ball.AddStartingForce();
       
    }

    public void ComputerScores()
    {
        computerScore++;
        this.playerScoreText.text = computerScore.ToString();
        this.ball.ResetPosition();
        this.PlayerPaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
        this.ball.AddStartingForce();
    
    }

  

}