using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    //calling scenes
    private string startGameSceneName = "StartGame";
    private string quizSceneName =  "Quiz";
    private string achievementSceneName = "Achievements";
    
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
    
    //loading Quiz scene + function to call
    public void LoadQuizScene()
    {
        LoadScene(quizSceneName);
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
