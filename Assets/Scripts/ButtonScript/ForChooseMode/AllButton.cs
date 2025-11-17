namespace ForChooseMod
{
    public class AllButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnDifferentRoundClicked(MixedRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(1, 4, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}