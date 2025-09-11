using UnityEngine;

public class GameMediator : MonoBehaviour
{
    // GameInStartScreen is going to be singleton
    // UI is also going to be singleton
    private Countdown _countdown;

    public GameMediator(Countdown countdown)
    {
        _countdown = countdown;
        
        _countdown.SetMediator(this);
    }

    // Notify Function with different name:
    public void ChangeInTime(int i)
    {
        
    }

    public void Notify(object sender, string dataType, int param)
    {
        if (sender is Countdown)
        {
            return;
        }
        if (dataType == "TimeData")
        {
            // UI.getInstance().setTimeText(param)
            
            // 0초가 되었을때 
            if (param == 0)
            {

                // UI.getInstance().endGame(param)
                // GameInStartScreen.getInstance().endGame()
            }
        }
    }

}
