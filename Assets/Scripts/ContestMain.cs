using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SocialPlatforms;
using UnityEditor;

public class ContestMain : MonoBehaviour
{
    GameObject bal;
    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Default;
    public float x, y, z;
    public int rand = 0;
    public int rand2;
    public int score = 0;
    public CoinSystem coinSystem;
    public TMP_Text coinText;
    public GameObject[] hoopArr;
    Adds adds;


    // Start is called before the first frame update
    public void Start()
    {

        Time.timeScale = 1;

        adds = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Adds>();

        if (PlayerPrefs.GetInt("equipBall1") == 1)
        {
            Instantiate(Ball1, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball1;
        }
        else if (PlayerPrefs.GetInt("equipBall3") == 1)
        {
            Instantiate(Ball3, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball3;
        }
        else if (PlayerPrefs.GetInt("equipBall2") == 1)
        {
            Instantiate(Ball2, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball2;
        }
        else if (PlayerPrefs.GetInt("equipBall4") == 1)
        {
            Instantiate(Ball4, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball4;
        }
        else if (PlayerPrefs.GetInt("equipBall5") == 1)
        {
            Instantiate(Ball5, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball5;
        }
        else
        {
            Instantiate(Default, new Vector3(x, y, z), Quaternion.identity);
            bal = Default;
        }

        adds.LoadFullSize();
    }
    public void Func()
    {
        hoopArr[rand].SetActive(false);
        rand2 = rand;
        rand = Random.Range(0, 5);
        while (rand == rand2)
        {
            rand = Random.Range(0, 5);
        }
        hoopArr[rand].SetActive(true);
        score = score + 1;
        if (score > PlayerPrefs.GetInt("high", 0))
        {
            PlayerPrefs.SetInt("high", score);
        }
        coinSystem.AddCoins(score);
        coinText.text = "+ " + score.ToString() + " coins";
    }
}
