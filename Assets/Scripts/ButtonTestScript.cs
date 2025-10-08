using UnityEngine;

public class ButtonTestScript : MonoBehaviour
{
    public void OnClick()
    {
        AchievementEvents.OnAnswerQuestionCorrectly?.Invoke(2);
    }
}
