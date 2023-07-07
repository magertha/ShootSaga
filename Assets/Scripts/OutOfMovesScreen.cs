using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutOfMovesScreen : MonoBehaviour
{
    public bool OOM = false;
    public GameOverScreen over;
    public LevelCleared lvcl;
    public GameObject oompanel;
    Adds adds;
    private void Start()
    {
        adds = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Adds>();
    }
    public void Setup()
    {
        if (over.GO == false && lvcl.LC == false)
        {
            adds.LoadFullSize();
            OOM = true;
            oompanel.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
