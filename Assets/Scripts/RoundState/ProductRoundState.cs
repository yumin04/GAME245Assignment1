using UnityEngine;

public class ProductRoundState : IRoundState
{
    private static ProductRoundState _instance;

    private ProductRoundState()
    {
        currentRoundType =  RoundType.Multiplication;
    }

    public static ProductRoundState GetInstance()
    {
        if (_instance == null)
            _instance = new ProductRoundState();

        return _instance;
    }

}