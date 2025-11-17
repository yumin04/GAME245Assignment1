// TODO: answer in range
// TODO: WHen creating fake answer, make sure the answers are not overlapping with each other.
    // EX: if answer = 14, then fake answers should not be 14
// TODO: Don't make the answers negative


    using UnityEngine;
    using System.Collections.Generic;
    using System.Linq;


    public class SubtractionQuestionCommand : QuestionCommand
    {
        public override void Execute()
        {
            // Pick two numbers to subtract
            int firstNumber = Random.Range(0, 13);   // 0–12
            int secondNumber = Random.Range(0, 13);  // 0–12

            int correctAnswer = firstNumber - secondNumber; // 0–24

            // Pick incorrect answers in the same rough range
            int incorrectAnswer1 = Random.Range(0, 25);
            while (incorrectAnswer1 == correctAnswer)
            {
                incorrectAnswer1 = Random.Range(0, 25);
            }

            int incorrectAnswer2 = Random.Range(0, 25);
            while (incorrectAnswer2 == correctAnswer || incorrectAnswer2 == incorrectAnswer1)
            {
                incorrectAnswer2 = Random.Range(0, 25);
            }

            List<int> answers = new List<int> { correctAnswer, incorrectAnswer1, incorrectAnswer2 };

            // Shuffle answers
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
