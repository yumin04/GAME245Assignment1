using System;
using UnityEngine;
using UnityEngine.UI;
namespace ForChooseMod
{
    public class FourQuestionButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAnswerButton(0);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 2, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}