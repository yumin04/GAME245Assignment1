using UnityEngine;

public class Countdown : MonoBehaviour
{
    private ITimer _timer;
    private GameMediator _gameMediator;

    public void SetTimer(ITimer timer)
    {
        _timer = timer;
        _timer.SetMediator(this);
    }

    public void StartTimer()
    {
        StartCoroutine(_timer.RunTimer());
    }

    public void ChangeInTime(int i)
    {
        _gameMediator.ChangeInTime(i);
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator =  gameMediator;
    }
}
