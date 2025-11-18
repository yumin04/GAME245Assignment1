using System;using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;


public class AchievementUI : MonoBehaviour
{
    private static AchievementUI instance;
    
    [SerializeField] private GameObject achievementPanelOne;
    [SerializeField] private GameObject achievementPanelTwo;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public static AchievementUI GetInstance()
    {
        return instance;
    }

    public void OnClickBackButton()
    {
        AppManager.GetInstance().LoadStartScreen();
    }

    public void OnClickPageOneButton()
    {
        achievementPanelOne.gameObject.SetActive(true);
        achievementPanelTwo.gameObject.SetActive(false);
    }

    public void OnClickPageTwoButton()
    {
        achievementPanelOne.gameObject.SetActive(false);
        achievementPanelTwo.gameObject.SetActive(true);
    }
}
