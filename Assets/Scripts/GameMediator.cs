using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameMediator : MonoBehaviour
{
    // GameInStartScreen is going to be singleton
    // UI is also going to be singleton
    [SerializeField]
    private Countdown _countdown;
    
    [SerializeField] public QuestionGenerator questionGenerator;
    // startScreen, gameScreen (Can be Enum)


    // private QuestionCommand _defaultQuestionCommand = new DivisionQuestionCommand();
    
    public void Start()
    {
        UI.GetInstance().SetMediator(this);
        _countdown.SetMediator(this);
        Game.GetInstance().SetMediator(this);

        AppManager.GetInstance().ChangeToMenuState();

    }

    private void OnEnable()
    {
        AchievementEvents.OnAchievementUnlocked += SetAchievementText;
    }
    private void OnDisable()
    {
        AchievementEvents.OnAchievementUnlocked -= SetAchievementText;
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
        AppManager.GetInstance().ChangeToWaitState();
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
        AppManager.GetInstance().ChangeToGameState();
        _countdown.StartRoundTimer();
    }
    
    public void EndGame(int questionsCorrect)
    {
        UI.GetInstance().DisplayEndScreen(questionsCorrect);
        AchievementEvents.OnRoundComplete?.Invoke(questionsCorrect);
        AppManager.GetInstance().ChangeToResultState();
    }

    public void SetAchievementText(string text)
    {
        UI.GetInstance().ChangeAchievementText(text);
    }
    public void QuitButtonClicked()
    {
        AppManager.GetInstance().Quit();
    }

    public void AchievementButtonClicked()
    {
        AppManager.GetInstance().LoadAchievementScreen();
        // AppManager.GetInstance().ChangeToAchievementState();
    }

    public int GetNumRounds()
    {
        return IRoundState.Instance.numRounds;
    }
    
    public void SetNumRounds(int numRounds)
    {
        IRoundState.Instance.numRounds = numRounds;
    }

    public void SetRoundState(IRoundState roundState)
    {
        IRoundState.Instance.SetState(roundState);
        questionGenerator.SetQuestionCommand(IRoundState.Instance.GetCurrentCommand());
    }

    public void MenuStartButtonClicked()
    {
        AppManager.GetInstance().ChangeToChooseModState();
    }
}
