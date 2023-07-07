using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;
//using static UnityEditorInternal.ReorderableList;

public class ContestHoop : MonoBehaviour
{
    GameObject bal;
    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Default;
    public GameObject came;
    public TMP_Text scoreCounter;
    public ContestMain conmain;

    public void Start()
    {

        if (PlayerPrefs.GetInt("equipBall1") == 1)
        {
            bal = Ball1;
        }
        else if (PlayerPrefs.GetInt("equipBall3") == 1)
        {
            bal = Ball3;
        }
        else if (PlayerPrefs.GetInt("equipBall2") == 1)
        {
            bal = Ball2;
        }
        else if (PlayerPrefs.GetInt("equipBall4") == 1)
        {
            bal = Ball4;
        }
        else if (PlayerPrefs.GetInt("equipBall5") == 1)
        {
            bal = Ball5;
        }
        else
        {
            bal = Default;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D ballRigidbody = bal.GetComponent<Rigidbody2D>();

            if (ballRigidbody.velocity.y < 0.1f)
            {
                conmain.Func();
                //hoopArr[rand].SetActive(false);
                //rand = Random.Range(0, 4);
                //hoopArr[rand].SetActive(true);
                //score = score + 1;
                scoreCounter.text = "Score: " + conmain.score.ToString();
            }
        }
    }
}

