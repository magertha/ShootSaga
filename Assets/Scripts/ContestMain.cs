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
    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Ball6, Ball7, Ball8, Ball9, Ball10, Ball11, Ball12, Ball13, Ball14, Ball15, Ball16, Ball17, Ball18, Ball19, Default;
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
        else if (PlayerPrefs.GetInt("equipBall6") == 1)
        {
            Instantiate(Ball6, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball6;
        }
        else if (PlayerPrefs.GetInt("equipBall7") == 1)
        {
            Instantiate(Ball7, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball7;
        }
        else if (PlayerPrefs.GetInt("equipBall8") == 1)
        {
            Instantiate(Ball8, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball8;
        }
        else if (PlayerPrefs.GetInt("equipBall9") == 1)
        {
            Instantiate(Ball9, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball9;
        }
        else if (PlayerPrefs.GetInt("equipBall10") == 1)
        {
            Instantiate(Ball10, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball10;
        }
        else if (PlayerPrefs.GetInt("equipBall11") == 1)
        {
            Instantiate(Ball11, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball11;
        }
        else if (PlayerPrefs.GetInt("equipBall12") == 1)
        {
            Instantiate(Ball12, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball12;
        }
        else if (PlayerPrefs.GetInt("equipBall13") == 1)
        {
            Instantiate(Ball13, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball13;
        }
        else if (PlayerPrefs.GetInt("equipBall14") == 1)
        {
            Instantiate(Ball14, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball14;
        }
        else if (PlayerPrefs.GetInt("equipBall15") == 1)
        {
            Instantiate(Ball15, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball15;
        }
        else if (PlayerPrefs.GetInt("equipBall16") == 1)
        {
            Instantiate(Ball16, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball16;
        }
        else if (PlayerPrefs.GetInt("equipBall17") == 1)
        {
            Instantiate(Ball17, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball17;
        }
        else if (PlayerPrefs.GetInt("equipBall18") == 1)
        {
            Instantiate(Ball18, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball18;
        }
        else if (PlayerPrefs.GetInt("equipBall19") == 1)
        {
            Instantiate(Ball19, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball19;
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
        //coinSystem.AddCoins(score);
        //coinText.text = "+ " + score.ToString() + " coins";
    }
}
