using Unity.VisualScripting;

public enum RoundType {
    Addition,
    Subtraction,
    Multiplication,
    Division,
    All
}


public abstract class IRoundState
{
    // Instantiating ProductRoundState as default
    public static IRoundState Instance = ProductRoundState.GetInstance();
    
    public int numRounds;
    public RoundType currentRoundType { get; set; }
    protected abstract QuestionCommand _questionCommand { get; }

    public int GetNumRounds() => numRounds;

    public void SetState(IRoundState state)
    {
        Instance = state;
    }

    // public abstract void HandleOnRoundEnd(int correctAnswers);
    public QuestionCommand GetCurrentCommand()
    {
        return _questionCommand;
    }
}