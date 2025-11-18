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
    protected override void ResetPosition()
    {
        rowIndex = 0;
        columnIndex = 1;
    }
}