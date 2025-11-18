using System;
using UnityEngine;
using UnityEngine.UI;
namespace ForChooseMod
{
    public class ThreeQuestionButton : IQuestionNumberButton
    {
        private void Start()
        {
            OnClick();
        }
        public override void OnClick()
        {
            GameEvents.OnQuestionNumberButtonClicked.Invoke(this);
            UI.GetInstance().OnNumRoundsButtonClicked(3);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 0, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}