using System.Collections;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    
    private GameMediator _gameMediator;
    

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
        for (int timeRemaining = maximumTime; timeRemaining > 0; timeRemaining--)
        {
            _gameMediator.ChangeInTime(timeRemaining);
            yield return new WaitForSeconds(1);
        }
        _gameMediator.ChangeInTime(0);
    }

    public void EndTimer()
    {
        StopAllCoroutines();
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator =  gameMediator;
    }
}
