using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForAchievements
{
    public class BackButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAchievementButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 0, gameObject.transform.position, OnClick);
            AchievementState.GetInstance().AddScreenAction(screenAction);
        }
    }
}
    
