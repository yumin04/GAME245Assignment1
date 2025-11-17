using System;
using UnityEngine;
using UnityEngine.UI;
namespace ForChooseMod
{
    public class ThreeQuestionButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAnswerButton(0);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 2, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}