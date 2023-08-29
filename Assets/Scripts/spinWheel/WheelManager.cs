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
    GameObject watchAdder, spinner, skip, price;
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

        //Scene scene = SceneManager.GetActiveScene();
        //spinner = GameObject.FindGameObjectWithTag("Spinner");
        //price = GameObject.FindGameObjectWithTag("Price");
        //watchAdder = GameObject.FindGameObjectWithTag("WatchAdder");
        //skip = GameObject.FindGameObjectWithTag("Skip");
        //price.GetComponent<Image>().enabled = false;
        //winT = GameObject.FindGameObjectWithTag("PriceText").GetComponent<TMP_Text>();
        //oneTime = false;
        //int currentGold = PlayerPrefs.GetInt("Gold", 0);
        //adds = GetComponent<Adds>();
        //Keep track of the player money
        UpdateText();

        //Sets the gameobject
        wheel.setWheel(gameObject);

        //Sets the callback
    //    if (scene.name != "SampleEndlessScene")
    //    {
    //        wheel.AddCallback((index) =>
    //        {
    //            isTook = true;
    //            switch (index)
    //            {

    //                case 1:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 1.2f);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.2x";
    //                    break;
    //                case 2:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 1.4f);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.4x";
    //                    break;
    //                case 3:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 1);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "10 Diamonds";
    //                    diamondValue = PlayerPrefs.GetInt("Diamond");
    //                    diamondValue += 10;
    //                    PlayerPrefs.SetInt("Diamond", diamondValue);
    //                    break;
    //                case 4:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 1.6f);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.6x";
    //                    break;
    //                case 5:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 1.8f);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.8x";
    //                    break;
    //                case 6:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 2);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "2x";
    //                    break;
    //                case 7:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 3);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "3x";
    //                    break;
    //                case 8:
    //                    LevelsCoin.totalGold = (int)(LevelsCoin.totalGold * 4);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "4x";
    //                    break;
    //            }
    //            price.GetComponent<Image>().enabled = true;
    //            skip.SetActive(false);
    //            UpdateText();
    //        });
    //    }
    //    else
    //    {
    //        wheel.AddCallback((index) =>
    //        {
    //            isTook = true;
    //            switch (index)
    //            {
    //                case 1:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 1.2f);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.2x";
    //                    break;
    //                case 2:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 1.4f);
    //                    currentGold += LevelsCoin.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.4x";
    //                    break;
    //                case 3:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 1);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "10 Diamonds";
    //                    diamondValue = PlayerPrefs.GetInt("Diamond");
    //                    diamondValue += 10;
    //                    PlayerPrefs.SetInt("Diamond", diamondValue);
    //                    break;
    //                case 4:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 1.6f);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.6x";
    //                    break;
    //                case 5:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 1.8f);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "1.8x";
    //                    break;
    //                case 6:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 2);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "2X";
    //                    break;
    //                case 7:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 3);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "3x";
    //                    break;
    //                case 8:
    //                    CoinManager.totalGold = (int)(CoinManager.totalGold * 4);
    //                    currentGold += CoinManager.totalGold;
    //                    PlayerPrefs.SetInt("Gold", currentGold);
    //                    PlayerPrefs.Save();
    //                    winT.text = "4x";
    //                    break;
    //            }
    //            price.GetComponent<Image>().enabled = true;
    //            skip.SetActive(false);
    //            UpdateText();
    //        });
    //    }
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

    //public void ok()
    //{
    //    watchAdder.SetActive(false);
    //}
}
