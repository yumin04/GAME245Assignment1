public class AchievementState : IState
{
    private static AchievementState instance;

    public static AchievementState GetInstance()
    {
        if (instance == null)
        {
            instance = new AchievementState();
        }
        return instance;
    }
}