
namespace ForAchievements
{
    public class PageTwoButton : IPageNumberButton
    {
        public override void OnClick()
        {
            GameEvents.OnPageNumberButtonClicked.Invoke(this);
            AchievementUI.GetInstance().OnClickPageTwoButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 2, gameObject.transform.position, OnClick);
            AchievementState.GetInstance().AddScreenAction(screenAction);
        }
    }
}