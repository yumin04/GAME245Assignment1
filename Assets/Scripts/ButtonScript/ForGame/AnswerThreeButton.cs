using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForGame
{
    public class AnswerThreeButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAnswerButton(2);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 2, gameObject.transform.position, OnClick);
            GameState.GetInstance().AddScreenAction(screenAction);
        }
    }
}