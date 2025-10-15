public class AchievementProgress {
    public bool IsUnlocked {get; private set;}
    public string Id {get; private set;}
    public int Progress { get; private set; }
    
    public string CustomProgress {get; private set;}

    public AchievementProgress(string id, bool alreadyUnlocked = false, int progress = 0, string customProgress = null) {
        this.Id = id;
        this.IsUnlocked = alreadyUnlocked;
        this.Progress = progress;
        this.CustomProgress = customProgress;
    }

    public void UnlockAchievement()
    {
        this.IsUnlocked = true;
        AchievementEvents.OnAchievementUnlocked?.Invoke(this.Id);
    }
    public void SetUnlocked(bool isUnlocked) {
        this.IsUnlocked = isUnlocked;
    }

    public void IncrementProgress() {
        this.Progress++;
    }
    
    public void SetProgress(int amount) {
        this.Progress = amount;
    }

    public void SetCustomProgress(string progress) {
        this.CustomProgress = progress;
    }

    public override string ToString() {
        string customProgress = this.CustomProgress;
        if (customProgress.Length == 0) customProgress = "None";
        return $"{Id}: IsUnlocked={IsUnlocked}, Progress={Progress}, CustomProgress={customProgress}";
    }
    
    // from Tatiana Gasparre and Nathan Jones' code
    public void ResetProgress()
    {
        this.Progress = 0;
    }
}