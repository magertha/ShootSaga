using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
public class WheelManager : MonoBehaviour
{

    //Creates the wheel
    SpinWheel wheel = new SpinWheel(8);
    //GameObject watchAdder, spinner, skip, price;
    public GameObject spin,spinner;
    private int diamondValue;
    //public Text text;
    TMP_Text winT;
    public bool oneTime, isShowing;
    private bool internet = false;
    Adds adds;
    public static bool isTook, reward, rewardAns;
    public bool test;

    void Start()
    {
        reward = false;
        isTook = false;
        StartCoroutine(CheckInternetConnection());
        Scene scene = SceneManager.GetActiveScene();
        //spinner = GameObject.FindGameObjectWithTag("Spinner");
        //price = GameObject.FindGameObjectWithTag("Price");
        //watchAdder = GameObject.FindGameObjectWithTag("WatchAdder");
        //skip = GameObject.FindGameObjectWithTag("Skip");
        //price.GetComponent<Image>().enabled = false;
        //winT = GameObject.FindGameObjectWithTag("PriceText").GetComponent<TMP_Text>();
        oneTime = false;
        int currentGold = PlayerPrefs.GetInt("TotalCoins", 0);
        //adds = GetComponent<Adds>();
        //Keep track of the player money
        UpdateText();

        //Sets the gameobject
        wheel.setWheel(gameObject);

        //Sets the callback
            wheel.AddCallback((index) =>
            {
                isTook = true;
                switch (index)
                {

                    case 1:
                        currentGold += 50;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 2:
                        currentGold += 100;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 3:
                        currentGold += 200;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 4:
                        currentGold += 500;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 5:
                        currentGold += 0;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 6:
                        currentGold += 5;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 7:
                        currentGold += 10;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                    case 8:
                        currentGold += 20;
                        PlayerPrefs.SetInt("TotalCoins", currentGold);
                        PlayerPrefs.Save();
                        Debug.Log("true");
                        break;
                }
                spin.SetActive(false);
                UpdateText();
            });
        }
    void Update()
    {

        //if (adds == null)
        //{
        //    adds = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Adds>();
        //}
        //test = !Adds.active;
        //if (rewardAns == true)
        //{
        //    watchAdder.SetActive(false);
        //    rewardAns = false;
        //}
    }

    IEnumerator CheckInternetConnection()
    {
        UnityWebRequest request = new UnityWebRequest("http://google.com");
        yield return request.SendWebRequest();
        if (request.error != null)
        {
            internet = false;
        }
        else
        {
            internet = true;
        }
    }
    public void UpdateText()
    {
        //text.text = money + "";
    }

    public void OkWin()
    {
        //win.SetActive(false);
    }

    public void Spin()
    {

        StartCoroutine(wheel.StartNewRun());
        UpdateText();
        //watchAdder.SetActive(false);
        //spinner.SetActive(false);
       // AudioManager.Instance.PlaySFX("Wheel");
    }

    public void WatchAd()
    {

        //if (internet)
        //{
        //    adds.ShowRewardedAd();
        //    reward = true;

        //}
        //else if (!internet)
        //{
        //    Debug.Log("intyok");
        //}


    }
    public void collecter()
    {
        spinner.SetActive(false);
        spin.SetActive(true);

    }

    //public void ok()
    //{
    //    watchAdder.SetActive(false);
    //}
}
