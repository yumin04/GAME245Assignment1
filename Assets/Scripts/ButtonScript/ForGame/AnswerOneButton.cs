using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForGame
{
    public class AnswerOneButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAnswerButton(0);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 0, gameObject.transform.position, OnClick);
            GameState.GetInstance().AddScreenAction(screenAction);
        }
    }
}