public abstract class IPageNumberButton : ISelectionButton
{
    protected override void OnEnable()
    {
        GameEvents.OnPageNumberButtonClicked += OnOtherButtonClicked;
        base.OnEnable();
    }
    protected override void OnDisable()
    {
        GameEvents.OnPageNumberButtonClicked -= OnOtherButtonClicked;
        base.OnDisable();
    }
}