using System;

public static class AchievementEvents {

    // use this when a question is answered correctly, include the seconds remaining
    public static Action<int> OnAnswerQuestionCorrectly;
    // use this when a round ends, include the number of correct answers
    // this should probably actually be OnGameComplete; feel free to rename.
    public static Action<int> OnRoundComplete;
    // for the huh achievement
    public static Action OnEquationClicked;
    
    // this should probably actually be OnGameStart; feel free to rename.
    public static Action OnRoundStart;
}