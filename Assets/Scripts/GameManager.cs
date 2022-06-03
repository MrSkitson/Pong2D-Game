using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    private int _playerScore { get; set; }  
    public Text playerScoreText;

    public Paddle computerPaddle;
    private int _computerScore { get; set; }    
    public Text computerScoreText;

    bool _playerWon = false;


    private void Start()
    {
        NewGame();
      
    }

    private void Update()
    {//Button "R" do restart game - start NewGame() method
        if (Input.GetKeyUp(KeyCode.R))
            NewGame();
        if(_playerScore > 5) { 
            _playerWon = true;
            //setactive screen UI
            //Button next Level
        }
    }



    public void NewGame()
    {
        //SetPlayerScore(0);
       // SetComputerScore(0);
        StartRound();
        _playerWon = false;
       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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

    private void StartNextLevel()
    {
        //Need to add code for button next level. Loadscene 
    }
   


}
