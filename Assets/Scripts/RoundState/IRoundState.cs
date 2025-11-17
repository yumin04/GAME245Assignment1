public enum RoundType {
    Addition,
    Subtraction,
    Multiplication,
    Division,
    All
}


public abstract class IRoundState
{
    public static IRoundState Instance;

    public int numRounds;
    public RoundType currentRoundType { get; set; }

    public int GetNumRounds() => numRounds;

    public void SetState(IRoundState state)
    {
        Instance = state;
    }

    // public abstract void HandleOnRoundEnd(int correctAnswers);
}