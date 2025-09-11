using System.Collections;
using UnityEngine;

public interface ITimer
{
    void SetMediator(Countdown countdown);
    IEnumerator RunTimer();
}
