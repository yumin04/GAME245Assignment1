using System.Collections;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private GameMediator _gameMediator;

    private int _timeRemaining = 0;

    public void StartGameTimer()
    {
        StartCoroutine(this.RunTimer(5));
    }

    public void StartRoundTimer()
    {
        StartCoroutine(this.RunTimer(10));
    }
    public IEnumerator RunTimer(int maximumTime)
    {
        for (_timeRemaining = maximumTime; _timeRemaining > 0; _timeRemaining--)
        {
            _gameMediator.ChangeInTime(_timeRemaining);
            yield return new WaitForSeconds(1);
        }
        _gameMediator.ChangeInTime(0);
    }

    public void EndTimer()
    {
        StopAllCoroutines();
    }

    public int GetTimeRemaining()
    {
        return _timeRemaining;
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator =  gameMediator;
    }
}
