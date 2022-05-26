
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;

    public  void PlayerScores()
    {
        _playerScore++;
        Debug.Log(_playerScore);
        this.ball.ResetPosition();
    }

    public void ComputerScore()
    {
        _computerScore++;
        Debug.Log(_computerScore);
        this.ball.ResetPosition();
    }

    private void ResetBall()
    { 

    }


}
