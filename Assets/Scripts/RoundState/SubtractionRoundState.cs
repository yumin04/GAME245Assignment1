using UnityEngine;

public class SubtractionRoundState : IRoundState
{
    private static SubtractionRoundState _instance;
    protected override QuestionCommand _questionCommand => new SubtractionQuestionCommand();
    private SubtractionRoundState()
    {
        currentRoundType =  RoundType.Subtraction;
    }

    public static SubtractionRoundState GetInstance()
    {
        if (_instance == null)
            _instance = new SubtractionRoundState();

        return _instance;
    }

}