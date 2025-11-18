using System;
using UnityEngine;
using UnityEngine.UI;
namespace ForChooseMod
{
    public class FourQuestionButton : IQuestionNumberButton
    {
        public override void OnClick()
        {
            GameEvents.OnQuestionNumberButtonClicked.Invoke(this);
            UI.GetInstance().OnNumRoundsButtonClicked(4);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 1, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}