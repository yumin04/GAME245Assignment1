using UnityEngine;

public class GameInStartScreen : MonoBehaviour, IGame
{
    private static GameInStartScreen instance;

    public IGame GetInstance()
    {
        if (instance == null)
        {
            instance = new GameObject("GameInStartScreen").AddComponent<GameInStartScreen>();
        }
        return instance;
    }

    public void EndLogic()
    {
        // After timer end, it will change screen and notify Game to change to Game screen
    }
    public void StartLogic()
    {
        // it will make the start panel available and hookup buttons
        // what else?
    }
}
