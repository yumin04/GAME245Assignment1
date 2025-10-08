using UnityEngine;
using UnityEngine.EventSystems;

public class EquationDisplay : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData) {
        AchievementEvents.OnEquationClicked?.Invoke();
    }
}