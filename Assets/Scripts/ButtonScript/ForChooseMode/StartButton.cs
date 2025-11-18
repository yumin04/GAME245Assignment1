using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForChooseMod
{
    public class StartButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickStartButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(2, 0, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}