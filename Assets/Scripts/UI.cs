using System;using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public enum CurrentScreen
{
    StartScreen,
    GameScreen,
    EndScreen
}


public class UI : MonoBehaviour
{
    private static UI instance;
    private GameMediator _gameMediator;

    private CurrentScreen currentScreen;

    public GameObject startScreen;
    public GameObject gameScreen;
    public GameObject endScreen;
    
    public TextMeshProUGUI startScreenCountdownText;
    public TextMeshProUGUI gameScreenCountdownText;
    
    public TextMeshProUGUI problemText;
    public TextMeshProUGUI answerChoiceOne;
    public TextMeshProUGUI answerChoiceTwo;
    public TextMeshProUGUI answerChoiceThree;
    
    public TextMeshProUGUI resultText;
    
    
    public void Awake()
    {
        instance = this;
    }
    
    public static UI GetInstance()
    {
        return instance;
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator = gameMediator;
    }

    public void ChangeCountdownText(int currTime)
    {
        if (currentScreen == CurrentScreen.StartScreen)
        {
            startScreenCountdownText.text = currTime + "";
        } 
        else if (currentScreen == CurrentScreen.GameScreen)
        {
            gameScreenCountdownText.text = currTime + "";
        }
    }

    public void OnClickAnswerButton(int i)
    {
        _gameMediator.AnswerButtonClicked(i);
    }
    
    public void OnClickStartButton()
    {
        _gameMediator.StartButtonClicked();
    }
    public void OnClickQuitButton()
    {
        _gameMediator.QuitButtonClicked();
    }
    public void OnClickRestartButton()
    {
        DisplayStartScreen();
        DisableCounterText();
        _gameMediator.RestartButtonClicked();   
    }


    public void DisplayStartScreen()
    {
        currentScreen = CurrentScreen.StartScreen;
        DisplayScreen();
    }
    
    public void DisplayGameScreen()
    {
        currentScreen = CurrentScreen.GameScreen;
        DisplayScreen();
    }

    private void DisplayScreen()
    {
        startScreen.SetActive(false);
        gameScreen.SetActive(false);
        endScreen.SetActive(false);
        if (currentScreen == CurrentScreen.StartScreen)
        {
            startScreen.SetActive(true);
        }
        if (currentScreen == CurrentScreen.GameScreen)
        {
            gameScreen.SetActive(true);
        }
        if (currentScreen == CurrentScreen.EndScreen)
        {
            endScreen.SetActive(true);
        }
    }
    


    public void MoveToNextQuestion(int x, int y, int answer1, int answer2, int answer3)
    {
        problemText.text = x + " * " + y;
        answerChoiceOne.text = answer1 + "";
        answerChoiceTwo.text = answer2 + "";
        answerChoiceThree.text = answer3 + "";
    }

    public void DisplayEndScreen(int questionsCorrect)
    {
        currentScreen = CurrentScreen.EndScreen;
        DisplayScreen();
        resultText.text = "Result: " + questionsCorrect + " / 3";
    }

    public void EnableCounterText()
    {
        startScreenCountdownText.gameObject.SetActive(true);        
    }
    
    private void DisableCounterText()
    {
        startScreenCountdownText.gameObject.SetActive(false);
    }
}
