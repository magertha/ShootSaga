using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{   
    public void StartGame()
    {
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