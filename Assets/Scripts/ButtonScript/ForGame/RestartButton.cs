using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForGame
{
    public class RestartButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickRestartButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 0, gameObject.transform.position, OnClick);
            GameState.GetInstance().AddScreenAction(screenAction);
        }
    }
}