using System;
using UnityEngine;
using UnityEngine.UI;
namespace ForChooseMod
{
    public class DivisionButton : IQuestionTypeButton
    {
        public override void OnClick()
        {
            GameEvents.OnQuestionTypeButtonClicked.Invoke(this);
            UI.GetInstance().OnDifferentRoundClicked(DivisionRoundState.GetInstance());
        }
        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 3, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}