using UnityEngine;

public class GameInGameScreen : MonoBehaviour, IGame
{
    private static GameInGameScreen instance;

    public IGame GetInstance()
    {
        if (instance == null)
        {
            instance = new GameObject("GameInStartScreen").AddComponent<GameInGameScreen>();
        }
        return instance;
    }

    public void EndLogic()
    {
        // If timer ends then
    }
    public void StartLogic()
    {
        // This is where we play the Game Logic, so this will be Main Gameloop
    }
    
    // After receiving button input from UI, this is where it will go
    public void HandleButton(string dataType, int param)
    {
        // Is the answer Correct? (param = 1)
        // Is the answer Incorrect? (param = 0)
    }
}
