using UnityEngine;
using System.Collections.Generic;
using System.Linq;


// Only Doing Multiplication
public class ProductQuestionCommand : QuestionCommand
{
    public override void  Execute()
    {
        int firstNumber = Random.Range(1, 13);
        int secondNumber = Random.Range(1, 13);
        int correctAnswer = firstNumber * secondNumber;
        int incorrectAnswer1 = Random.Range(1, 145);
        int incorrectAnswer2 = Random.Range(1, 145);
        List<int> answers = new List<int> { correctAnswer, incorrectAnswer1, incorrectAnswer2 };
        for (int i = 0; i < answers.Count; i++)
        {
            int randIndex = Random.Range(i, answers.Count);
            (answers[i], answers[randIndex]) = (answers[randIndex], answers[i]);
        }
        
        _questionAndAnswer.firstNumber = firstNumber;
        _questionAndAnswer.secondNumber = secondNumber;
        _questionAndAnswer.operationType = " * ";
        _questionAndAnswer.answer1 = answers[0];
        _questionAndAnswer.answer2 = answers[1];
        _questionAndAnswer.answer3 = answers[2];
        _questionAndAnswer.correctAnswerIndex = answers.IndexOf(correctAnswer);
        
    }
}