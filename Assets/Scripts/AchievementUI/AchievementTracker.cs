using UnityEngine;
using UnityEngine.UI;

public class AchievementTracker : MonoBehaviour
{
    public Text mathematician;
    public Text thatWasClose;
    public Text InForTheLongHaulI;
    public Text InForTheLongHaulII;
    public Text InForTheLongHaulIII;
    public Text APlusI;
    public Text APlusII;
    public Text APlusIII;
    public Text MathMaster;
    public Text DailyStreak;
    public Text huh;


    public Text PerfectMath;
    public Text PerfectAddition;
    public Text PerfectDivider;
    public Text PerfectSubtractor;
    public Text PerfectMultiplier;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var map = AchievementSaves.LoadAchievements();
        mathematician.text = map["mathematician"].Progress + "/10";
        
        if (map["thatwasclose"].IsUnlocked)
        {
            thatWasClose.text = "1/1";
        }
        
        InForTheLongHaulI.text = map["inforthelonghaul_1"].Progress + "/15";
        InForTheLongHaulII.text = map["inforthelonghaul_2"].Progress + "/30";
        InForTheLongHaulIII.text = map["inforthelonghaul_3"].Progress + "/60";
        APlusI.text = map["APlus1"].Progress + "/1";
        APlusII.text = map["APlus2"].Progress + "/10";
        APlusIII.text = map["APlus3"].Progress + "/30";

        
        if (map["mathmaster"].IsUnlocked)
        {
            MathMaster.text = "1/1";
        }
        
        DailyStreak.text = map["dailyStreak"].Progress + "/5";

        if (map["huh"].IsUnlocked)
        {
            huh.text = "1/1";
        }
        
        if (map["PerfectMath"].IsUnlocked)
        {
            PerfectMath.text = "1/1";
        }
        
        if (map["PerfectAddition"].IsUnlocked)
        {
            PerfectAddition.text = "1/1";
        }
        
        if (map["PerfectDivider"].IsUnlocked)
        {
            PerfectDivider.text = "1/1";
        }
        
        if (map["PerfectSubtractor"].IsUnlocked)
        {
            PerfectSubtractor.text = "1/1";
        }
        
        if (map["PerfectMultiplier"].IsUnlocked)
        {
            PerfectMultiplier.text = "1/1";
        }


    }
}
