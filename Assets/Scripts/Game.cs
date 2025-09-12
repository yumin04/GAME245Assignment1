using UnityEngine;

public class Game : MonoBehaviour
{
    private static Game _instance;
    
    [SerializeField]
    private GameMediator _gameMediator;

    private int questionSolved = 0;
    private int questionCorrect = 0;
    private int maximumQuestions = 3;
    public void Awake()
    {
        _instance = this;
    }

    public static Game GetInstance()
    {
        return _instance;
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator = gameMediator;
    }
    

    public void CheckIfQuestionLeft()
    {
        if (questionSolved < maximumQuestions)
        {
            questionSolved++;
            _gameMediator.GenerateNextQuestion();
        }
        else
        {
            Debug.Log("question correct: "  + questionCorrect);
            _gameMediator.EndGame(questionCorrect);
        }
    }

    public void Reset()
    {
        questionSolved = 0;
        questionCorrect = 0;
    }

    public void ProcessAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            questionCorrect++;
        }

        CheckIfQuestionLeft();
    }
}
