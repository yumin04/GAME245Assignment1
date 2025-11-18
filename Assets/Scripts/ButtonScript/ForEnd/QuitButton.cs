namespace ForEnd
{
    public class QuitButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickQuitButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0,2, gameObject.transform.position, OnClick);
            ResultState.GetInstance().AddScreenAction(screenAction);
        }
    }
}