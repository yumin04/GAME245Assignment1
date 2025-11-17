// 1 2 3 -> selecting answer
// or arrow key? do we want to do this with select instead?

public class GameState : IState
{
    private static GameState instance;

    public static GameState GetInstance()
    {
        if (instance == null)
        {
            instance = new GameState();
        }
        return instance;
    }
}
