using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForMenu
{
    public class StartButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAchievementButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 1, gameObject.transform.position, OnClick);
            MenuState.GetInstance().AddScreenAction(screenAction);
        }
    }
}