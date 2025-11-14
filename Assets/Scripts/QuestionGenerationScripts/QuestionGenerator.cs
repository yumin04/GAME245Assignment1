
using UnityEngine;

// TODO: Setter for QuestionCommand

public class QuestionGenerator : MonoBehaviour
{ 
    private QuestionCommand _questionCommand;
    
    public void SetQuestionCommand(QuestionCommand command)
    {
        _questionCommand = command;
    }
    public bool CheckForCorrectAnswer(int answerIndex)
    {
        if (_questionCommand == null)
        {
            Debug.LogError("QuestionCommand is not set on QuestionGenerator.");
            return false;
        }
        
        return answerIndex == _questionCommand.GetCorrectAnswerIndex();
    }

    public QuestionAndAnswer GenerateQuestion()
    {
        if (_questionCommand == null)
        {
            Debug.LogError("QuestionCommand is not set on QuestionGenerator.");
            return default;
        }
        
        _questionCommand.Execute();
        return _questionCommand._questionAndAnswer;
    }
}
