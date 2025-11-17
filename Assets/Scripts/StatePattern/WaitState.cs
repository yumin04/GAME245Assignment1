public class WaitState : IState
{
    private static WaitState instance;

    public static WaitState GetInstance()
    {
        if (instance == null)
        {
            instance = new WaitState();
        }
        return instance;
    }
}