using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.InputSystem.Controls;

public class Timer : MonoBehaviour
{
    public BallControl ballControl;
    float countdown = 90;
    public TMP_Text tex;
    public GameObject up;
    //public ContestMain conmain;
    //public int highScore;

    IEnumerator EXA()
    {
        yield return new WaitForSeconds(2.4f);

        BallControl.inputen = true;

        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        double b = System.Math.Round(countdown, 0);
        if (countdown < 60)
        {
            tex.text = "0:" + b.ToString();
            if (countdown < 10)
            {
                tex.text = "0:0" + b.ToString();
            }
        }
        if (countdown >= 60)
        {
            tex.text = "1:" + (b - 60).ToString();
            if ((b - 60) < 10)
            {
                tex.text = "1:0" + (b - 60).ToString();
            }
        }

        if (countdown <= 0)
        {
            Time.timeScale = 0;
            up.SetActive(true);
        }
    }

    void Start()
    {
        BallControl.inputen = false;
    }
    void Update()
    {
        StartCoroutine(EXA());
    }
}
