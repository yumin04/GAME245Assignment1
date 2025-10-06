using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour {
    // tracks all of the achievement IDs and their progress
    private Dictionary<string, AchievementProgress> achievementProgressTable;
    private void Awake() {
        AchievementEvents.OnRoundComplete += OnRoundComplete;
        AchievementEvents.OnAchievementEarned += OnAchievementEarned;
        AchievementEvents.OnEquationClicked += OnEquationClicked;
        AchievementEvents.OnAnswerQuestionCorrectly += OnAnswerQuestionCorrectly;
        achievementProgressTable = AchievementSaves.LoadAchievements();
    }
    
    private void OnDestroy() {
        AchievementEvents.OnRoundComplete -= OnRoundComplete;
        AchievementEvents.OnAchievementEarned -= OnAchievementEarned;
        AchievementEvents.OnEquationClicked -= OnEquationClicked;
        AchievementEvents.OnAnswerQuestionCorrectly -= OnAnswerQuestionCorrectly;
    }
    

    private void OnRoundComplete(int correctAnswers) {
        TrackAPlus(correctAnswers);
        TrackDailyStreak();
    }
    
    private void OnAnswerQuestionCorrectly(int timeRemaining) {
        TrackThatWasClose(timeRemaining);
        TrackMathMaster(timeRemaining);
        TrackInForTheLongHaul();
    }
    

    private void OnAchievementEarned(string achievementID) { 
        // use this to track when all achievements earned
    }

    private void OnEquationClicked()
    {
        if (AchievementIsUnlocked("huh")) {
            Debug.Log("Equation was clicked but achievement was already unlocked.");
            return;
        }
        UnlockAchievement("huh");
    }
    
    private void TrackDailyStreak() {
        // setcustomprogress and getcustomprogress may be useful helper methods here
    }

    private void TrackAPlus(int correctAnswers) {

    }

    private void TrackThatWasClose(int timeRemaining)
    {
        if (timeRemaining > 3) return;
        if (AchievementIsUnlocked("thatwasclose"))
        {
            Debug.Log("Achievement 'That was Close!' was already unlocked.");
            return;
        }
        UnlockAchievement("thatwasclose");
        
    }

    private void TrackMathMaster(int timeRemaining) {
        
    }

    private void TrackInForTheLongHaul() {
        
    }
    private void UnlockAchievement(string achievementId) {
        Debug.Log("Unlocked achievement " + achievementId);
        achievementProgressTable.TryGetValue(achievementId, out var achievementProgress);
        AchievementSaves.Unlock(achievementId);
        if (achievementProgress == null) {
            Debug.Log($"Achievement {achievementId} was (not actually) unlocked (but pretend it was).");
            return;
        }
        achievementProgress.UnlockAchievement();
    }

    private bool AchievementIsUnlocked(string achievementId) {
        achievementProgressTable.TryGetValue(achievementId, out var value);
        if (value != null) {
            return value.IsUnlocked;
        }

        return false;
    }

    private string GetCustomProgress(string achievementId) {
        achievementProgressTable.TryGetValue(achievementId, out var value);
        if (value != null) {
            return value.CustomProgress;
        }
        return null;
    }

    private void SetCustomProgress(string achievementId, string value) {
        achievementProgressTable.TryGetValue(achievementId, out var achievementProgress);
        achievementProgress.SetCustomProgress(value);
        AchievementSaves.SetCustomProgress(achievementId, value);
    }
}