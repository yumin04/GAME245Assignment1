
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    [SerializeField] private QuestionCommand _questionCommand;
    public bool CheckForCorrectAnswer(int answerIndex)
    {
        return answerIndex == _questionCommand.GetCorrectAnswerIndex();
    }

    public QuestionAndAnswer GenerateQuestion()
    {
        _questionCommand.Execute();
        return _questionCommand._questionAndAnswer;
    }
}
