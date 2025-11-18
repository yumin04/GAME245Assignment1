using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;

public class AppManager : MonoBehaviour
{
    private static AppManager instance;

    // Scene → State 매핑 테이블
    private Dictionary<string, Action> sceneStateMap;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;

        // 🔥 초기화 시 매핑 테이블 구성
        BuildSceneStateMap();
    }

    public static AppManager GetInstance() => instance;

    private void BuildSceneStateMap()
    {
        sceneStateMap = new Dictionary<string, Action>()
        {
            { "GameScene", ChangeToMenuState },
            { "Achievements", ChangeToAchievementState },
        };
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        if (sceneStateMap.TryGetValue(scene.name, out var stateAction))
        {
            stateAction.Invoke();
        }
        else
        {
            Debug.LogWarning($"[AppManager] No state mapped for scene '{scene.name}'");
        }
    }

    // Scene load methods
    public void LoadStartScreen() => SceneManager.LoadScene("GameScene");
    public void LoadAchievementScreen() => SceneManager.LoadScene("Achievements");

    
    public void ChangeToMenuState()
    {
        UserInputActionHandler.Instance.ChangeToMenuState();
    }

    public void ChangeToWaitState()
    {
        UserInputActionHandler.Instance.ChangeToWaitState();
    }

    public void ChangeToGameState()
    {
        UserInputActionHandler.Instance.ChangeToGameState();
    }

    public void ChangeToResultState()
    {
        UserInputActionHandler.Instance.ChangeToResultState();
    }

    public void ChangeToAchievementState()
    {
        UserInputActionHandler.Instance.ChangeToAchievementState();
    }

    public void ChangeToChooseModState()
    {
        UserInputActionHandler.Instance.ChangeToChooseModState();
    }
    public void Quit()
    {
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}