using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{   
    public void GoHome()
    {
        AudioManager.Instance.PlaySFX("Click");
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}