using UnityEngine;

[CreateAssetMenu(fileName = "AchievementDefinition", menuName = "Scriptable Objects/AchievementDefinition")]
public class AchievementDefinition : ScriptableObject {
    public string Id;
    public string Name;
    public string Description;
}