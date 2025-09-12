using UnityEngine;

public class Game : MonoBehaviour
{
    private static Game _instance;
    public GameMediator  _gameMediator;

    public static Game GetInstance()
    {
        return _instance;
    }
    public void SetMediator(GameMediator gameMediator)
    {
        _gameMediator = gameMediator;
    }

    public GameMediator GetMediator()
    {
        return _gameMediator;
    }
}
