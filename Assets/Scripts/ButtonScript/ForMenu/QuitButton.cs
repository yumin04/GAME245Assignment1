using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForMenu
{
    public class QuitButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAchievementButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 0, gameObject.transform.position, OnClick);
            MenuState.GetInstance().AddScreenAction(screenAction);
        }
    }
}