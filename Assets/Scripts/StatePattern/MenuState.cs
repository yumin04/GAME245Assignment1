
// Arrow key to increment and choose different selections
// Would need to implement border or indicator object as well...
// Indicator should work fine
// 
public class MenuState : IState
{
    private static MenuState instance;

    public static MenuState GetInstance()
    {
        if (instance == null)
        {
            instance = new MenuState();
        }
        return instance;
    }
}
