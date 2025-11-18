using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForChooseMod
{
    public class SubtractionButton : IQuestionTypeButton
    {
        public override void OnClick()
        {
            GameEvents.OnQuestionTypeButtonClicked.Invoke(this);
            UI.GetInstance().OnDifferentRoundClicked(SubtractionRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 1, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}