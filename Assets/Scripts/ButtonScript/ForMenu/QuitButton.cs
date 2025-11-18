using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForMenu
{
    public class QuitButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickQuitButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 1, gameObject.transform.position, OnClick);
            MenuState.GetInstance().AddScreenAction(screenAction);
        }
    }
}