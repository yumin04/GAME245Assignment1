using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForMenu
{
    public class StartButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickMenuStartButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 0, gameObject.transform.position, OnClick);
            MenuState.GetInstance().AddScreenAction(screenAction);
        }
    }
}