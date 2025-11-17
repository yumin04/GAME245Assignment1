public class ResultState : IState
{
    private static ResultState instance;

    public static ResultState GetInstance()
    {
        if (instance == null)
        {
            instance = new ResultState();
        }
        return instance;
    }
}