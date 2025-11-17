using UnityEngine;

public class SubtractionRoundState : IRoundState
{
    private static SubtractionRoundState _instance;

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