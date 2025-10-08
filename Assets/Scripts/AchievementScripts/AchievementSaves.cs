using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class AchievementSaves
{
    private const string progressPrefix = "progress_ ";
    private const string customProgressPrefix = "customprogress_";
    private const string achievementPrefix = "achievement_";
        
    public static List<AchievementDefinition> LoadAllAchievementDefinitions() {
        return Resources.LoadAll<AchievementDefinition>("Achievements").ToList();
    }

    public static void IncrementProgress(string Id) {
        Debug.Log($"IncrementProgress called: Will eventually increment the progress of achievement {Id} in storage.");
    }

    public static Dictionary<string, AchievementProgress> LoadAchievements() {
        Debug.Log($"LoadAchievements called: will eventually load all of the achievements from disk.");
        var achievementProgressTable = new Dictionary<string, AchievementProgress>();

        foreach (var achievementDefinition in LoadAllAchievementDefinitions())
        {
            string id = achievementDefinition.Id;
            bool alreadyUnlocked = (PlayerPrefs.GetInt(achievementPrefix + id, 0) == 1);
            int progress = PlayerPrefs.GetInt(achievementPrefix + progressPrefix + id, 0);
            string customProgress = PlayerPrefs.GetString(achievementPrefix + customProgressPrefix + id, null);
            var achievementProgress = new AchievementProgress(id, alreadyUnlocked, progress, customProgress);
            achievementProgressTable.Add(id, achievementProgress);
        }
        
        return achievementProgressTable;
    }

    public static void Unlock(string id) {
        Debug.Log($"Unlock called: Will eventually save unlock of {id} to disk.");
        PlayerPrefs.SetInt(achievementPrefix + id, 1);
    }

    public static void SetCustomProgress(string id, string value) {
        Debug.Log($"Will set a custom value {value} for achievement {id}");
    }
}