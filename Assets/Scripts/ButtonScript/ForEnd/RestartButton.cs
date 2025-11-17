namespace ForEnd
{
        public class RestartButton : IButtonListener
        {
            public override void OnClick()
            {
                UI.GetInstance().OnClickRestartButton();
            }

            public override void AddToState()
            {
                ScreenAction screenAction = new ScreenAction(2, 0, gameObject.transform.position, OnClick);
                ResultState.GetInstance().AddScreenAction(screenAction);
            }
        }
}