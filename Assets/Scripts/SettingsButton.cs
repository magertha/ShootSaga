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
        AudioManager.Instance.PlaySFX("Click");
        settingsPanel.SetActive(true);
    }
    public void CloseSettings()
    {
        AudioManager.Instance.PlaySFX("Click");
        settingsPanel.SetActive(false);
    }
    public void Achievements()
    {
        AudioManager.Instance.PlaySFX("Click");
        achievementsPanel.SetActive(true);
    }
    public void CloseAchievements()
    {
        AudioManager.Instance.PlaySFX("Click");
        achievementsPanel.SetActive(false);
    }
}