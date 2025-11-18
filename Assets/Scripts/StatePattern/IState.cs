using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class IState
{
    private Dictionary<int, List<ScreenAction>> screenActions = new Dictionary<int, List<ScreenAction>>();
    protected int rowIndex;
    protected  int columnIndex;

    // ---------------------------
    // ScreenAction 등록
    // ---------------------------
    public void AddScreenAction(ScreenAction a)
    {
        // row가 없으면 생성
        if (!screenActions.ContainsKey(a.row))
            screenActions[a.row] = new List<ScreenAction>();

        var row = screenActions[a.row];

        // column 인덱스 크기 맞추기
        while (row.Count <= a.column)
            row.Add(null);

        row[a.column] = a;
    }


    // ---------------------------
    // 이동 처리 (Dictionary 기반)
    // ---------------------------
    public void HandleRightClicked()
    {
        int maxCol = screenActions[rowIndex].Count - 1;
        if (columnIndex < maxCol)
            columnIndex++;
    }

    public void HandleLeftClicked()
    {
        if (columnIndex > 0)
            columnIndex--;
    }

    public void HandleUpClicked()
    {
        if (rowIndex > 0)
        {
            rowIndex--;

            // 이동한 row에서 column 범위 조정
            int maxCol = screenActions[rowIndex].Count - 1;
            if (columnIndex > maxCol)
                columnIndex = maxCol;
        }
    }

    public void HandleDownClicked()
    {
        int maxRow = screenActions.Count - 1;
        if (rowIndex < maxRow)
        {
            rowIndex++;

            // 이동한 row에서 column 범위 조정
            int maxCol = screenActions[rowIndex].Count - 1;
            if (columnIndex > maxCol)
                columnIndex = maxCol;
        }
    }


    // ---------------------------
    // 확정 선택 처리
    // ---------------------------
    public void HandleConfirmClicked()
    {
        screenActions[rowIndex][columnIndex].action.Invoke();
    }


    // ---------------------------
    // indicator 위치 반환
    // ---------------------------
    public Vector2 ReturnIndicatorPosition()
    {
        return screenActions[rowIndex][columnIndex].pos;
    }


    // ---------------------------
    // State 진입
    // ---------------------------
    public virtual void OnEnter()
    {
        GameEvents.OnAllButtonEnabled?.Invoke();
        ResetPosition(); 
    }
    protected virtual void ResetPosition()
    {
        rowIndex = 0;
        columnIndex = 0;
    }
}
