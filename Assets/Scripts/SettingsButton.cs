using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject achievementsPanel;
    public void Stngs()
    {
        settingsPanel.SetActive(true);
    }
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
    public void Achievements()
    {
        achievementsPanel.SetActive(true);
    }
    public void CloseAchievements()
    {
        achievementsPanel.SetActive(false);
    }
}