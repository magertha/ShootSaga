using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Instance.MusicSource.volume = .4f;
        AudioManager.Instance.PlayMusic("Music");
    }
    public void StartGame()
    {
        AudioManager.Instance.MusicSource.volume = .2f;
        AudioManager.Instance.PlaySFX("Click");
        if (PlayerPrefs.GetInt("levelsUnlocked") > 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("levelsUnlocked"));
        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("levelsUnlocked")+1);
        }
    }
}