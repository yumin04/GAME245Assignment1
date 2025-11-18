using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForWait
{
    public class NullButton : IButtonListener
    {
        public override void OnClick()
        {

        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 0, gameObject.transform.position, OnClick);
            WaitState.GetInstance().AddScreenAction(screenAction);
        }
    }
}