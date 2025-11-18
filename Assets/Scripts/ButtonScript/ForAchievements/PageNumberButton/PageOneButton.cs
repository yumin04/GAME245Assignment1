
namespace ForAchievements
{
    public class PageOneButton : IPageNumberButton
    {
        private void Start()
        {
            GameEvents.OnPageNumberButtonClicked.Invoke(this);
        }
        
        public override void OnClick()
        {
            GameEvents.OnPageNumberButtonClicked.Invoke(this);
            AchievementUI.GetInstance().OnClickPageOneButton();
        }

        public override void AddToState()
        {
            ScreenAction screenAction = new ScreenAction(0, 1, gameObject.transform.position, OnClick);
            AchievementState.GetInstance().AddScreenAction(screenAction);
        }
    }
}