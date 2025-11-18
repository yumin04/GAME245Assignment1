namespace ForChooseMod
{
    public class FiveQuestionButton : IQuestionNumberButton
    {
        public override void OnClick()
        {
            GameEvents.OnQuestionNumberButtonClicked.Invoke(this);
            UI.GetInstance().OnNumRoundsButtonClicked(5);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(row, 2, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}