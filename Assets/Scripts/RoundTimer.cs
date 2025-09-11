using System.Collections;
using UnityEngine;

public class RoundTimer : MonoBehaviour, ITimer
{
    private int maximumTime = 10;
    private Countdown _countdown;
    public IEnumerator RunTimer()
    {
        for (int timeRemaining = maximumTime; timeRemaining > 0; timeRemaining--)
        {
            _countdown.ChangeInTime(timeRemaining);
            yield return new WaitForSeconds(1);
        }
        // this will trigger end logic
        _countdown.ChangeInTime(0);
    }
    public void SetMediator(Countdown countdown)
    {
        _countdown =  countdown;
    }
}
