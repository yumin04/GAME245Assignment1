namespace ForChooseMod
{
    public class AllButton : IQuestionTypeButton
    {
        public override void OnClick()
        {
            GameEvents.OnQuestionTypeButtonClicked.Invoke(this);
            UI.GetInstance().OnDifferentRoundClicked(MixedRoundState.GetInstance());
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 4, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}