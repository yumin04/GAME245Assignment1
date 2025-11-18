using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForChooseMod
{
    public class MultiplicationButton : IQuestionTypeButton
    {
        private void Start()
        {
            OnClick();
        }

        public override void OnClick()
        {
            GameEvents.OnQuestionTypeButtonClicked.Invoke(this);
            UI.GetInstance().OnDifferentRoundClicked(ProductRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 2, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}