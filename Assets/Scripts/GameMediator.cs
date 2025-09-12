using UnityEngine;

public class GameMediator : MonoBehaviour
{
    // GameInStartScreen is going to be singleton
    // UI is also going to be singleton
    [SerializeField]
    private Countdown _countdown;

    private int currScreen = 0;
    // startScreen, gameScreen (Can be Enum)
    public void Awake()
    {
        //UI.GetInstance().SetMediator(this)
        _countdown.SetMediator(this);        
        Game.GetInstance().SetMediator(this);
    }
    public void ChangeInTime(int i)
    {
        if (i == 0)
        {
            //UI.GetInstance().DisplayTimeEnd(currScreen)
            //Game.GetInstance().ProcessTimeEnd(currScreen)
        }
        // UI.GetInstance().ChangeStartCountDownText()
        // UI.GetInstance().ChangeRoundCountDownText()
    }

    public void AnswerButtonClicked(int i)
    {
        // int x, int y, int correctNumber = questionGenerator.GetAnswerChoice(i)
        // _countdown.EndTimer();
        // Game.GetInstance().ProcessAnswer(x, y, answerChoice)
    }



    public void StartButtonClicked()
    {
        // UI.GetInstance().DisplayGameScreen()
        // GenerateNextQuestion()
    }
    public void RestartButtonClicked()
    {
        // Game.GetInstance().Reset()
        // UI.GetInstance().DisplayStartScreen()
    }

    // Inside ProcessAnswer in Game Class, it will recall GenerateNextQuestion() or EndGame()
    public void GenerateNextQuestion()
    {
        // int x, int y, int answer1, int answer2, int answer3 = questionGenerator.GetNextQuestion(i)
        // _countdown.StartTimer()
        // UI.GetInstance().MoveToNextQuestion(x, y, answer1, answer2, answer3)
    }
    
    public void EndGame(int questionsCorrect)
    {
        // UI.GetInstance().DisplayFinalScreen(questionsCorrect)
    }
    public void QuitButtonClicked()
    {
        Application.Quit();
    }
}
