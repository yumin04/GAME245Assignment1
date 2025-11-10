
using UnityEngine;

// TODO: Setter for QuestionCommand

public class QuestionGenerator : MonoBehaviour
{ 
    private QuestionCommand _questionCommand;
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
