using UnityEngine;

public class AdditionRoundState : IRoundState
{
    private static AdditionRoundState _instance;

    private AdditionRoundState()
    {
        currentRoundType =  RoundType.Addition;
    }

    public static AdditionRoundState GetInstance()
    {
        if (_instance == null)
            _instance = new AdditionRoundState();

        return _instance;
    }

}