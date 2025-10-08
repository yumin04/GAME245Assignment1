using UnityEngine;

public abstract class QuestionCommand : MonoBehaviour
{
    public QuestionAndAnswer _questionAndAnswer = new QuestionAndAnswer();
    public abstract void Execute();

    public int GetCorrectAnswerIndex()
    {
        return _questionAndAnswer.correctAnswerIndex;
    }
}