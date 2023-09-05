using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public GameObject TBCPanel;
    private void Start()
    {
        AudioManager.Instance.MusicSource.volume = .4f;
    }

    IEnumerator ExT()
    {
        yield return new WaitForSeconds(4f);
        TBCPanel.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        AudioManager.Instance.MusicSource.volume = .2f;
        AudioManager.Instance.PlaySFX("Click");
        if (PlayerPrefs.GetInt("levelsUnlocked") > 0 && PlayerPrefs.GetInt("levelsUnlocked") < 46)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("levelsUnlocked"));
        }
        else if (PlayerPrefs.GetInt("levelsUnlocked") == 46)
        {
            TBCPanel.gameObject.SetActive(true);
            StartCoroutine(ExT());
        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("levelsUnlocked")+1);
        }
    }
}