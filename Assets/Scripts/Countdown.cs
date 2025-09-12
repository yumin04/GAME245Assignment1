using System.Collections;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private ITimer _timer;
    
    private GameMediator _gameMediator;

    public void Awake()
    {
        _timer.SetMediator(this);
    }
    public void SetTimer(ITimer timer)
    {
        _timer = timer;
        _timer.SetMediator(this);
    }

    public void StartGameTimer()
    {
        StartCoroutine(this.RunTimer(2));
    }

    public void StartRoundTimer()
    {
        StartCoroutine(this.RunTimer(4));
    }
    public IEnumerator RunTimer(int maximumTime)
    {
        for (int timeRemaining = maximumTime; timeRemaining > 0; timeRemaining--)
        {
            _gameMediator.ChangeInTime(timeRemaining);
            yield return new WaitForSeconds(1);
        }
        _gameMediator.ChangeInTime(0);
    }

    public void EndTImer()
    {
        StopAllCoroutines();
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator =  gameMediator;
    }
}
