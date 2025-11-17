using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForChooseMod
{
    public class SubtractionButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnDifferentRoundClicked(SubtractionRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(2, 1, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}