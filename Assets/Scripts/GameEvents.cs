using System;

public static class GameEvents
{
    public static Action<IButtonListener> OnQuestionTypeButtonClicked;

    public static Action<IButtonListener> OnQuestionNumberButtonClicked;
    public static Action<IButtonListener> OnPageNumberButtonClicked;    
    public static Action OnAllButtonEnabled;

}