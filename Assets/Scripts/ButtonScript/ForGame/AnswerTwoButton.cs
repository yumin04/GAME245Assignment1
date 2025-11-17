using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForGame
{
    public class AnswerTwoButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAnswerButton(1);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 1, gameObject.transform.position, OnClick);
            GameState.GetInstance().AddScreenAction(screenAction);
        }
    }
}