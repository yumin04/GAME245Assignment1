using UnityEngine;

public class ButtonToStart : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameScreen;
    
    public void SwitchScreens()
    {
        startScreen.SetActive(false);
        gameScreen.SetActive(true);
            
    }
}