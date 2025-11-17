using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForChooseMod
{
    public class MultiplicationButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnDifferentRoundClicked(ProductRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(3, 1, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}