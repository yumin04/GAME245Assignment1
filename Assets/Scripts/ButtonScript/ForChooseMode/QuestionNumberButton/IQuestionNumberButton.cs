public abstract class IQuestionNumberButton : ISelectionButton
{
    
    protected int row = 1;
    protected override void OnEnable()
    {
        GameEvents.OnQuestionNumberButtonClicked += OnOtherButtonClicked;
        base.OnEnable();
    }
    protected override void OnDisable()
    {
        GameEvents.OnQuestionNumberButtonClicked -= OnOtherButtonClicked;
        base.OnDisable();
    }
}