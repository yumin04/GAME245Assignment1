public abstract class IQuestionTypeButton : ISelectionButton
{
    protected int row = 0;
    protected override void OnEnable()
    {
        GameEvents.OnQuestionTypeButtonClicked += OnOtherButtonClicked;
        base.OnEnable();
    }
    protected override void OnDisable()
    {
        GameEvents.OnQuestionTypeButtonClicked -= OnOtherButtonClicked;
        base.OnDisable();
    }
}