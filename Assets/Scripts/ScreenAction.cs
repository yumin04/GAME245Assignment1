using System;
using UnityEngine;

public class ScreenAction
{
    public int row;
    public int column;

    public Vector2 pos;
    public Action action;

    public ScreenAction(int row, int column, Vector2 pos, Action action)
    {
        this.row = row;
        this.column = column;
        this.pos = pos;
        this.action = action;
    }

    public ScreenAction()
    {
        
    }
}
