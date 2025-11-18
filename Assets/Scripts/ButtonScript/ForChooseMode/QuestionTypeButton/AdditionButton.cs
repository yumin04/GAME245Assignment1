using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForChooseMod
{
    public class AdditionButton : IQuestionTypeButton
    {
        public override void OnClick()
        {
            GameEvents.OnQuestionTypeButtonClicked.Invoke(this);
            UI.GetInstance().OnDifferentRoundClicked(AdditionRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 0, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}