using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class AchievementSaves {
    private const string achievementPrefix = "achievement_";
    private const string customProgressPrefix = "customprogress_";
    private const string progressPrefix = "progress_";

    public static void ResetPlayerPrefs() {
        Debug.Log("Player Prefs Reset.");
        PlayerPrefs.DeleteAll();
    }
    public static List<AchievementDefinition> LoadAllAchievementDefinitions() {
        return Resources.LoadAll<AchievementDefinition>("Achievements").ToList();
    }

    public static void IncrementProgress(string Id) {
        Debug.Log($"IncrementProgress called: incrementing the progress of achievement {Id} in storage.");
        int currentProgress = PlayerPrefs.GetInt(achievementPrefix + progressPrefix + Id);
        currentProgress++;
        PlayerPrefs.SetInt(achievementPrefix + progressPrefix + Id, currentProgress);
    }

    public static Dictionary<string, AchievementProgress> LoadAchievements() {
        Debug.Log($"LoadAchievements called: loading all of the achievements from disk.");
        var achievementProgressTable = new Dictionary<string, AchievementProgress>();
        foreach (var achievementDefinition in LoadAllAchievementDefinitions()) {
            string id = achievementDefinition.Id;
            bool alreadyUnlocked = (PlayerPrefs.GetInt(achievementPrefix + id, 0) == 1);
            int progress = PlayerPrefs.GetInt(achievementPrefix+progressPrefix+id, 0);
            string customProgress = PlayerPrefs.GetString(achievementPrefix + customProgressPrefix + id, "");
            var achievementProgress = new AchievementProgress(id, alreadyUnlocked, progress, customProgress);
            achievementProgressTable.Add(id, achievementProgress);
        }
        return achievementProgressTable;
    }

    public static void Unlock(string id) {
        Debug.Log($"Unlock called: saving unlock of {id} to disk.");
        PlayerPrefs.SetInt(achievementPrefix+id, 1);
    }

    public static void SetCustomProgress(string id, string value) {
        Debug.Log($"SetCustomProgress called: setting a custom value {value} for achievement {id}");
        PlayerPrefs.SetString(achievementPrefix+customProgressPrefix+id, value);
    }

    public static void SetProgress(string id, int progress) {
        PlayerPrefs.SetInt(achievementPrefix+progressPrefix+id, progress);
    }

    public static void PrintAllAchievementsFromDisk() {
        foreach (var achievementDefinition in LoadAllAchievementDefinitions()) {
            string id = achievementDefinition.Id;
            bool alreadyUnlocked = (PlayerPrefs.GetInt(achievementPrefix + id, 0) == 1);
            int progress = PlayerPrefs.GetInt(achievementPrefix + progressPrefix + id, 0);
            string customProgress = PlayerPrefs.GetString(achievementPrefix + customProgressPrefix + id, null);
            var achievementProgress = new AchievementProgress(id, alreadyUnlocked, progress, customProgress);
            Debug.Log(achievementProgress.ToString());
        }
    }
    
    // from Tatiana Gasparre and Nathan Jones' code
    public static void ResetProgress(string Id) {
        Debug.Log($"ResetProgress called: resetting the progress of achievement {Id} in storage.");
        int currentProgress = PlayerPrefs.GetInt(achievementPrefix + progressPrefix + Id);
        currentProgress = 0;
        PlayerPrefs.SetInt(achievementPrefix + progressPrefix + Id, currentProgress);
    }
}