// What am I going to do for States?
// User input
// esc -> exit, inside IState
// R -> restart
// Arrow key -> moving indicator object
// Main Action Press the action

// Create ScreenAction

// int x, int y for coordinate of indicator object
    // -> then return Vector3 so indicator can move to that position
// Vector3 variable to store
// Action to invoke the action




// Each State will be a singleton pattern


using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public abstract class IState
{
    private Dictionary<int, List<ScreenAction>> screenActions = new Dictionary<int, List<ScreenAction>>();
    private int xIndex;
    private int yIndex;

    public void AddScreenAction(ScreenAction screenAction)
    {
        screenActions[screenAction.y].Insert(screenAction.x, screenAction);
    }

    public void HandleRightClicked()
    {
        if (xIndex + 1 < screenActions[yIndex].Count)
            xIndex++;
    }

    public void HandleLeftClicked()
    {
        if (xIndex - 1 >= 0)
            xIndex--;
    }

    public void HandleUpClicked()
    {
        if (yIndex + 1 < screenActions.Count)
            yIndex++;
    }

    public void HandleDownClicked()
    {
        if (yIndex - 1 >= 0)
            yIndex--;
    }

    public void HandleConfirmClicked()
    {
        screenActions[yIndex][xIndex].action.Invoke();
    }

    public Vector2 ReturnIndicatorPosition()
    {
        return screenActions[xIndex][yIndex].pos;
    }
}
