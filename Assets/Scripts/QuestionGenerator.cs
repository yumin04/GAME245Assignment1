using UnityEngine;
using System.Collections.Generic;

public class QuestionGenerator : MonoBehaviour
{
    private int _correctAnswerIndex = 0;
    public bool CheckForCorrectAnswer(int i)
    {
        
        return i == _correctAnswerIndex;
    }

    public (int, int, int, int, int) GetNextQuestion()
    {
        int x = Random.Range(1, 13); 
        int y = Random.Range(1, 13);
        int correctAnswer = x * y;
        int incorrectAnswer1 = Random.Range(1,13) * Random.Range(1, 13);
        int incorrectAnswer2 = Random.Range(1,13) * Random.Range(1, 13);
        List<int> answers = new List<int> { correctAnswer, incorrectAnswer1, incorrectAnswer2 };
        
        for (int i = 0; i < answers.Count; i++)
        {
            int randIndex = Random.Range(i, answers.Count);
            (answers[i], answers[randIndex]) = (answers[randIndex], answers[i]);
        }
        _correctAnswerIndex = answers.IndexOf(correctAnswer);

        return (x, y, answers[0], answers[1], answers[2]);
    }
}
