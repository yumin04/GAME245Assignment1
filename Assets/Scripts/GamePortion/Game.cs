using UnityEngine;

public class Game : MonoBehaviour
{
    private static IGame _instance;

    public static IGame GetInstance()
    {
        return _instance;
    }

    public void SetInstance(IGame instance)
    {
        _instance = instance;
    }

    public void StartLogic()
    {
        _instance.StartLogic();
    }
    public void EndLogic()
    {
        _instance.EndLogic();
    }
}
