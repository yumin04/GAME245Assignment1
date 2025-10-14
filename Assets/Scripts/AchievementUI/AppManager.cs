using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    //calling scenes
    private string startGameSceneName = "GameScene";
    private string achievementSceneName = "Achievements";
    
    private static AppManager instance;
    private void Awake()
    {
        // Singleton pattern + DontDestroyOnLoad
        if (instance == null)
        {
            instance = this;
        }
    }


    public static AppManager GetInstance()
    {
        return instance;
    }
    
    
    //loading StartGame scene + function to call
    private void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void LoadStartScreen()
    {
        LoadScene(startGameSceneName);
    }

    public void LoadAchievementScreen()
    {
        
        LoadScene(achievementSceneName);
    }
    
    
    //quit application function
    public void Quit()
    { 
        Application.Quit();
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
    
}
