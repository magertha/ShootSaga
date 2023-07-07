using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessButton : MonoBehaviour
{
    public void Endless()
    {
        SceneManager.LoadScene(23);
    }
}