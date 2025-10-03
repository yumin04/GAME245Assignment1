using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class AchievementSaves {
    public static List<AchievementDefinition> LoadAllAchievementDefinitions() {
        return Resources.LoadAll<AchievementDefinition>("Achievements").ToList();
    }

    public static void IncrementProgress(string Id) {
        Debug.Log($"IncrementProgress called: Will eventually increment the progress of achievement {Id} in storage.");
    }

    public static Dictionary<string, AchievementProgress> LoadAchievements() {
        Debug.Log($"LoadAchievements called: will eventually load all of the achievements from disk.");
        var achievementProgressTable = new Dictionary<string, AchievementProgress>();
        achievementProgressTable.Add("huh", new AchievementProgress("huh", false));
        return achievementProgressTable;
    }

    public static void Unlock(string id) {
        Debug.Log($"Unlock called: Will eventually save unlock of {id} to disk.");
    }

    public static void SetCustomProgress(string id, string value) {
        Debug.Log($"Will set a custom value {value} for achievement {id}");
    }
}