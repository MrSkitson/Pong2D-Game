using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    private int _playerScore { get; set; }  
    public Text playerScoreText;

    public Paddle computerPaddle;
    private int _computerScore { get; set; }    
    public Text computerScoreText;


    private void Start()
    {
        NewGame();
    }

    private void Update()
    {//Button "R" do restart game - start NewGame() method
        if (Input.GetKeyUp(KeyCode.R))
            NewGame();
    }



    public void NewGame()
    {
        //SetPlayerScore(0);
       // SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
    public  void PlayerScores()
    {
        SetPlayerScore(_playerScore + 1);
       // _playerScore++;
        
        StartRound();
    }
    
    private void SetPlayerScore(int score)
    {
        _playerScore = score;
        playerScoreText.text = score.ToString();
    }
   

    public void ComputerScore()
    {
        // _computerScore++;
        SetComputerScore(_computerScore + 1);

        StartRound(); 
    }

    private void SetComputerScore(int score)
    {
        _computerScore = score;
        computerScoreText.text = score.ToString();
    }
   


}
