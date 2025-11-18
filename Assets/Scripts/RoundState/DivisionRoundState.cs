using UnityEngine;

public class DivisionRoundState : IRoundState
{
    private static DivisionRoundState _instance;
    protected override QuestionCommand _questionCommand => new DivisionQuestionCommand();
    private DivisionRoundState()
    {
        currentRoundType =  RoundType.Division;
    }

    public static DivisionRoundState GetInstance()
    {
        if (_instance == null)
            _instance = new DivisionRoundState();

        return _instance;
    }

}