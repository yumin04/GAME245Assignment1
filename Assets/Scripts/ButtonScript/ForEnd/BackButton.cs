namespace ForEnd
{
    public class BackButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickBackButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 0, gameObject.transform.position, OnClick);
            ResultState.GetInstance().AddScreenAction(screenAction);
        }
    }
}