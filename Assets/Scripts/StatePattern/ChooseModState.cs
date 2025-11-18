// Arrow key to increment and choose different selections
// Would need to implement border or indicator object as well...
// Indicator should work fine
// 
public class ChooseModState : IState
{
    private static ChooseModState instance;

    public static ChooseModState GetInstance()
    {
        if (instance == null)
        {
            instance = new ChooseModState();
        }
        return instance;
    }
    protected override void ResetPosition()
    {
        rowIndex = 2;
        columnIndex = 0;
    }
}