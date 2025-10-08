using UnityEngine;

public class GameMediator : MonoBehaviour
{
    // GameInStartScreen is going to be singleton
    // UI is also going to be singleton
    [SerializeField]
    private Countdown _countdown;
    
    [SerializeField]
    private QuestionGenerator questionGenerator;
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

    public void AnswerButtonClicked(int index)
    {
        bool isCorrect = questionGenerator.CheckForCorrectAnswer(index);
        if (isCorrect)
        {
            int timeRemaining = _countdown.GetTimeRemaining();
            AchievementEvents.OnAnswerQuestionCorrectly.Invoke(timeRemaining);
        }
        _countdown.EndTimer();
        Game.GetInstance().ProcessAnswer(isCorrect);
    }
    
    public void StartButtonClicked()
    {
        UI.GetInstance().EnableCounterText();
        UI.GetInstance().DisableStartButton();
        AchievementEvents.OnRoundStart.Invoke();
        _countdown.StartGameTimer();
    }
    public void RestartButtonClicked()
    {
        _countdown.EndTimer();
        Game.GetInstance().Reset();
        StartButtonClicked();
    }

    // Inside ProcessAnswer in Game Class, it will recall GenerateNextQuestion() or EndGame()
    public void GenerateNextQuestion()
    {            
        UI.GetInstance().DisplayGameScreen();
        QuestionAndAnswer questionAndAnswer = questionGenerator.GenerateQuestion();
        UI.GetInstance().MoveToNextQuestion(questionAndAnswer);
        _countdown.StartRoundTimer();

    }
    
    public void EndGame(int questionsCorrect)
    {
        UI.GetInstance().DisplayEndScreen(questionsCorrect);
        AchievementEvents.OnRoundComplete(questionsCorrect);
    }
    public void QuitButtonClicked()
    {
        Game.GetInstance().QuitApplication();
    }
}
