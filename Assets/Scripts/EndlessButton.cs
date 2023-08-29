using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessButton : MonoBehaviour
{
    public void Endless()
    {
        AudioManager.Instance.PlaySFX("Click");
        SceneManager.LoadScene(23);
    }
}