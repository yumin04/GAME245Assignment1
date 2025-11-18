
using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public class SubtractionQuestionCommand : QuestionCommand
{
    public override void Execute()
    {
        int firstNumber = Random.Range(0, 51);
        int secondNumber = Random.Range(0, firstNumber + 1); // ensures non-negative result

        int correctAnswer = firstNumber - secondNumber; // always >= 0

        // Incorrect answers also in range 0~50
        int incorrectAnswer1 = Random.Range(0, 51);
        while (incorrectAnswer1 == correctAnswer)
        {
            incorrectAnswer1 = Random.Range(0, 51);
        }

        int incorrectAnswer2 = Random.Range(0, 51);
        while (incorrectAnswer2 == correctAnswer || incorrectAnswer2 == incorrectAnswer1)
        {
            incorrectAnswer2 = Random.Range(0, 51);
        }

        List<int> answers = new List<int> { correctAnswer, incorrectAnswer1, incorrectAnswer2 };

        // Shuffle
        for (int i = 0; i < answers.Count; i++)
        {
            int randIndex = Random.Range(i, answers.Count);
            (answers[i], answers[randIndex]) = (answers[randIndex], answers[i]);
        }

        _questionAndAnswer.firstNumber = firstNumber;
        _questionAndAnswer.secondNumber = secondNumber;
        _questionAndAnswer.operationType = " - ";
        _questionAndAnswer.answer1 = answers[0];
        _questionAndAnswer.answer2 = answers[1];
        _questionAndAnswer.answer3 = answers[2];
        _questionAndAnswer.correctAnswerIndex = answers.IndexOf(correctAnswer);
    }

}
