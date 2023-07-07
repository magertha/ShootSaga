using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsButton : MonoBehaviour
{   
    public void Levels()
    {
        SceneManager.LoadScene(21);
    }
}