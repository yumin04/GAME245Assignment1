namespace ForChooseMod
{
    public class FiveQuestionButton : IButtonListener
    {
        public override void OnClick()
        {
            UI.GetInstance().OnClickAnswerButton(0);
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(2, 2, gameObject.transform.position, OnClick);
            ChooseModState.GetInstance().AddScreenAction(screenAction);
        }
    }
}