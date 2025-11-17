using UnityEngine;

public class MixedRoundState : IRoundState
{
    private static MixedRoundState _instance;

    private MixedRoundState()
    {
        currentRoundType =  RoundType.All;
    }

    public static MixedRoundState GetInstance()
    {
        if (_instance == null)
            _instance = new MixedRoundState();

        return _instance;
    }

}