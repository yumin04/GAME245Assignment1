using System;

public static class AchievementEvents {

    // use this when a question is answered correctly, include the seconds remaining
    public static Action<int> OnAnswerQuestionCorrectly;
    // use this when a round ends, include the number of correct answers
    public static Action<int> OnGameComplete;
    // for the huh achievement
    public static Action OnEquationClicked;
    // for Mathematician achievement, pass in ID
    public static Action<string> OnAchievementEarned;

    // these may be useful for the Math Master group?
    public static Action OnGameStart;
    public static Action OnRoundEnd;
}
