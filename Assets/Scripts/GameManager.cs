using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TMPro.TMP_Text PlayerScoreText;
    public TMPro.TMP_Text ComputerScoreText;

    public Paddle PlayerPaddle;
    public Paddle ComputerPaddle;

    private int playerscore;
    private int computerscore;

    public void PlayerScores() {
        playerscore++;
        Debug.Log("Player Score : " + playerscore);
        this.PlayerScoreText.text = playerscore.ToString();
        ResetRound();
    }

    public void ComputerScores() {
        computerscore++;
        Debug.Log("Computer Score : " + computerscore);
        this.ComputerScoreText.text = computerscore.ToString();
        ResetRound();
    }

    public void ResetRound() {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.PlayerPaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
    }
    
}
