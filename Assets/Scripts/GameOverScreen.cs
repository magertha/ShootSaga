using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public bool GO = false;
    public LevelCleared lvcl;
    public OutOfMovesScreen outofm;
    public GameObject oversc;
    Adds adds;
    private void Start()
    {
        adds = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Adds>();
    }
    public void Setup()
    {
        if (lvcl.LC == false && outofm.OOM == false)
        {
            adds.LoadFullSize();
            GO = true;
            oversc.SetActive(true);

        }
    }
}
