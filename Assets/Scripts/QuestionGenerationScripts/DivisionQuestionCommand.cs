using UnityEngine;
using System.Collections.Generic;
using System.Linq;

    namespace QuestionGenerationScripts
{
    public class DivisionQuestionCommand : QuestionCommand
    {
        public override void Execute()
        {
            int divisor = Random.Range(1, 13);        
            int wholeAnswer = Random.Range(1, 13);     
            int dividend = divisor * wholeAnswer;      

            int correctAnswer = wholeAnswer;
            
            int incorrectAnswer1 = Random.Range(1, 13);
            while (incorrectAnswer1 == correctAnswer)
            {
                incorrectAnswer1 = Random.Range(1, 13);
            }

            int incorrectAnswer2 = Random.Range(1, 13);
            while (incorrectAnswer2 == correctAnswer || incorrectAnswer2 == incorrectAnswer1)
            {
                incorrectAnswer2 = Random.Range(1, 13);
            }

            List<int> answers = new List<int> { correctAnswer, incorrectAnswer1, incorrectAnswer2 };
            
            for (int i = 0; i < answers.Count; i++)
            {
                int randIndex = Random.Range(i, answers.Count);
                (answers[i], answers[randIndex]) = (answers[randIndex], answers[i]);
            }

            
            _questionAndAnswer.firstNumber = dividend;      
            _questionAndAnswer.secondNumber = divisor;      
            _questionAndAnswer.operationType = " / ";
            _questionAndAnswer.answer1 = answers[0];
            _questionAndAnswer.answer2 = answers[1];
            _questionAndAnswer.answer3 = answers[2];
            _questionAndAnswer.correctAnswerIndex = answers.IndexOf(correctAnswer);
        }

    }
}
