using UnityEngine;

public class GameMediator : MonoBehaviour
{
    // GameInStartScreen is going to be singleton
    // UI is also going to be singleton
    [SerializeField]
    private Countdown _countdown;
    
    [SerializeField]
    private QuestionGenerator questionGenerator;

    private int currScreen = 0;
    // startScreen, gameScreen (Can be Enum)
    public void Awake()
    {
        UI.GetInstance().SetMediator(this);
        _countdown.SetMediator(this);        
        Game.GetInstance().SetMediator(this);
    }
    public void ChangeInTime(int currTime)
    {
        UI.GetInstance().ChangeCountdownText(currTime);
        if (currTime == 0)
        {
            Game.GetInstance().CheckIfQuestionLeft();
        }
    }

    public void AnswerButtonClicked(int i)
    {
        bool isCorrect = questionGenerator.CheckForCorrectAnswer(i);
        _countdown.EndTimer();
        Game.GetInstance().ProcessAnswer(isCorrect);
    }
    
    public void StartButtonClicked()
    {
        UI.GetInstance().EnableCounterText();
        _countdown.StartGameTimer();
    }
    public void RestartButtonClicked()
    {
        _countdown.EndTimer();
        Game.GetInstance().Reset();
    }

    // Inside ProcessAnswer in Game Class, it will recall GenerateNextQuestion() or EndGame()
    public void GenerateNextQuestion()
    {            
        UI.GetInstance().DisplayGameScreen();
        (int x, int y, int answer1, int answer2, int answer3) = questionGenerator.GetNextQuestion();
        UI.GetInstance().MoveToNextQuestion(x, y, answer1, answer2, answer3);
        _countdown.StartRoundTimer();

    }
    
    public void EndGame(int questionsCorrect)
    {
        UI.GetInstance().DisplayEndScreen(questionsCorrect);
    }
    public void QuitButtonClicked()
    {
        Game.GetInstance().QuitApplication();
    }
}
