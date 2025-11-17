using System;
using UnityEngine;

public class ScreenAction
{
    public int x;
    public int y;

    public Vector2 pos;
    public Action action;

    public ScreenAction(int x, int y, Vector2 pos, Action action)
    {
        this.x = x;
        this.y = y;
        this.pos = pos;
        this.action = action;
    }

    public ScreenAction()
    {
        
    }
}
