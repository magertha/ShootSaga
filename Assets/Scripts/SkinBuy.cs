using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinBuy : MonoBehaviour
{
    private int currentCoin, currentGem;
    public Image[] Stand;
    public Image[] Ball;
    public GameObject[] priceIcon ;
    public Button Ball1Buyer,Ball1Equiper,Ball1Equiped;
    public Button Ball2Buyer,Ball2Equiper,Ball2Equiped;
    public Button Ball3Buyer,Ball3Equiper,Ball3Equiped;
    public Button Ball4Buyer, Ball4Equiper, Ball4Equiped;
    public Button Ball5Buyer, Ball5Equiper, Ball5Equiped;
    public Button Ball6Buyer, Ball6Equiper, Ball6Equiped;
    public Button Ball7Buyer, Ball7Equiper, Ball7Equiped;
    public Button Ball8Buyer, Ball8Equiper, Ball8Equiped;
    public Button Ball9Buyer, Ball9Equiper, Ball9Equiped;
    public Button Ball10Buyer, Ball10Equiper, Ball10Equiped;
    public Button Ball11Buyer, Ball11Equiper, Ball11Equiped;
    public Button Ball12Buyer, Ball12Equiper, Ball12Equiped;
    public Button Ball13Buyer, Ball13Equiper, Ball13Equiped;
    public Button Ball14Buyer, Ball14Equiper, Ball14Equiped;
    public Button Ball15Buyer, Ball15Equiper, Ball15Equiped;
    public Button Ball16Buyer, Ball16Equiper, Ball16Equiped;
    public Button Ball17Buyer, Ball17Equiper, Ball17Equiped;
    public Button Ball18Buyer, Ball18Equiper, Ball18Equiped;
    public Button Ball19Buyer, Ball19Equiper, Ball19Equiped;
    public Button DefaultSkinEquiper, DefaultSkinEquiped;
    public int haveBall1, haveBall2, haveBall3, haveBall4, haveBall5, equipBall1,equipBall2,equipBall3,equipBall4, equipBall5, equipDefault;
    public int haveBall6, haveBall7, haveBall8, haveBall9, haveBall10, equipBall6, equipBall7, equipBall8, equipBall9, equipBall10;
    public int haveBall11, haveBall12, haveBall13, haveBall14, haveBall15, equipBall11, equipBall12, equipBall13, equipBall14, equipBall15;
    public int haveBall16, haveBall17, haveBall18, haveBall19, equipBall16, equipBall17, equipBall18, equipBall19;
    public GameObject WarningPanel, WarningPanelGems;
    // Start is called before the first frame update
    void Start()
    {
        currentCoin = PlayerPrefs.GetInt("TotalCoins", 0);
        currentGem = PlayerPrefs.GetInt("Diamond", 0);
        PlayerPrefs.GetInt("haveBall1", 0);
        PlayerPrefs.GetInt("haveBall3", 0);
        PlayerPrefs.GetInt("haveBall2", 0);
        PlayerPrefs.GetInt("haveBall4", 0);
        PlayerPrefs.GetInt("haveBall5", 0);
        PlayerPrefs.GetInt("haveBall6", 0);
        PlayerPrefs.GetInt("haveBall7", 0);
        PlayerPrefs.GetInt("haveBall8", 0);
        PlayerPrefs.GetInt("haveBall9", 0);
        PlayerPrefs.GetInt("haveBall10", 0);
        PlayerPrefs.GetInt("haveBall11", 0);
        PlayerPrefs.GetInt("haveBall12", 0);
        PlayerPrefs.GetInt("haveBall13", 0);
        PlayerPrefs.GetInt("haveBall14", 0);
        PlayerPrefs.GetInt("haveBall15", 0);
        PlayerPrefs.GetInt("haveBall16", 0);
        PlayerPrefs.GetInt("haveBall17", 0);
        PlayerPrefs.GetInt("haveBall18", 0);
        PlayerPrefs.GetInt("haveBall19", 0);
        PlayerPrefs.GetInt("equipBall1", 0);
        PlayerPrefs.GetInt("equipBall3", 0);
        PlayerPrefs.GetInt("equipBall2", 0);
        PlayerPrefs.GetInt("equipBall4", 0);
        PlayerPrefs.GetInt("equipBall5", 0);
        PlayerPrefs.GetInt("equipBall6", 0);
        PlayerPrefs.GetInt("equipBall7", 0);
        PlayerPrefs.GetInt("equipBall8", 0);
        PlayerPrefs.GetInt("equipBall9", 0);
        PlayerPrefs.GetInt("equipBall10", 0);
        PlayerPrefs.GetInt("equipBall11", 0);
        PlayerPrefs.GetInt("equipBall12", 0);
        PlayerPrefs.GetInt("equipBall13", 0);
        PlayerPrefs.GetInt("equipBall14", 0);
        PlayerPrefs.GetInt("equipBall15", 0);
        PlayerPrefs.GetInt("equipBall16", 0);
        PlayerPrefs.GetInt("equipBall17", 0);
        PlayerPrefs.GetInt("equipBall18", 0);
        PlayerPrefs.GetInt("equipBall19", 0);
        PlayerPrefs.GetInt("equipDefault", 0);
    }

    // Update is called once per frame
    void Update()
    {
        currentCoin = PlayerPrefs.GetInt("TotalCoins");
        currentGem = PlayerPrefs.GetInt("Diamond");
        if (PlayerPrefs.GetInt("haveBall1") == 1)
        {
            Ball1Buyer.gameObject.SetActive(false);
            Ball[0].color = new Color32(255, 255, 255, 255);
            Stand[0].color = new Color(255, 255, 255, 255);
            priceIcon[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall3") == 1)
        {
            Ball3Buyer.gameObject.SetActive(false);
            Ball[2].color = new Color32(255, 255, 255, 255);
            Stand[2].color = new Color(255, 255, 255, 255);
            priceIcon[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall2") == 1)
        {
            Ball2Buyer.gameObject.SetActive(false);
            Ball[1].color = new Color32(255, 255, 255, 255);
            Stand[1].color = new Color(255, 255, 255, 255);
            priceIcon[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall4") == 1)
        {
            Ball4Buyer.gameObject.SetActive(false);
            Ball[3].color = new Color32(255, 255, 255, 255);
            Stand[3].color = new Color(255, 255, 255, 255);
            priceIcon[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall5") == 1)
        {
            Ball5Buyer.gameObject.SetActive(false);
            Ball[4].color = new Color32(255, 255, 255, 255);
            Stand[4].color = new Color(255, 255, 255, 255);
            priceIcon[4].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall6") == 1)
        {
            Ball6Buyer.gameObject.SetActive(false);
            Ball[6].color = new Color32(255, 255, 255, 255);
            Stand[6].color = new Color(255, 255, 255, 255);
            priceIcon[5].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall7") == 1)
        {
            Ball7Buyer.gameObject.SetActive(false);
            Ball[7].color = new Color32(255, 255, 255, 255);
            Stand[7].color = new Color(255, 255, 255, 255);
            priceIcon[6].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall8") == 1)
        {
            Ball8Buyer.gameObject.SetActive(false);
            Ball[8].color = new Color32(255, 255, 255, 255);
            Stand[8].color = new Color(255, 255, 255, 255);
            priceIcon[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall9") == 1)
        {
            Ball9Buyer.gameObject.SetActive(false);
            Ball[8].color = new Color32(255, 255, 255, 255);
            Stand[8].color = new Color(255, 255, 255, 255);
            priceIcon[8].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall10") == 1)
        {
            Ball10Buyer.gameObject.SetActive(false);
            Ball[9].color = new Color32(255, 255, 255, 255);
            Stand[9].color = new Color(255, 255, 255, 255);
            priceIcon[9].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall11") == 1)
        {
            Ball11Buyer.gameObject.SetActive(false);
            Ball[10].color = new Color32(255, 255, 255, 255);
            Stand[10].color = new Color(255, 255, 255, 255);
            priceIcon[10].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall12") == 1)
        {
            Ball12Buyer.gameObject.SetActive(false);
            Ball[11].color = new Color32(255, 255, 255, 255);
            Stand[11].color = new Color(255, 255, 255, 255);
            priceIcon[11].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall13") == 1)
        {
            Ball13Buyer.gameObject.SetActive(false);
            Ball[12].color = new Color32(255, 255, 255, 255);
            Stand[12].color = new Color(255, 255, 255, 255);
            priceIcon[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall14") == 1)
        {
            Ball14Buyer.gameObject.SetActive(false);
            Ball[13].color = new Color32(255, 255, 255, 255);
            Stand[13].color = new Color(255, 255, 255, 255);
            priceIcon[13].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall15") == 1)
        {
            Ball15Buyer.gameObject.SetActive(false);
            Ball[14].color = new Color32(255, 255, 255, 255);
            Stand[14].color = new Color(255, 255, 255, 255);
            priceIcon[14].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall16") == 1)
        {
            Ball16Buyer.gameObject.SetActive(false);
            Ball[15].color = new Color32(255, 255, 255, 255);
            Stand[15].color = new Color(255, 255, 255, 255);
            priceIcon[15].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall17") == 1)
        {
            Ball17Buyer.gameObject.SetActive(false);
            Ball[16].color = new Color32(255, 255, 255, 255);
            Stand[16].color = new Color(255, 255, 255, 255);
            priceIcon[16].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall18") == 1)
        {
            Ball18Buyer.gameObject.SetActive(false);
            Ball[17].color = new Color32(255, 255, 255, 255);
            Stand[17].color = new Color(255, 255, 255, 255);
            priceIcon[17].SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall19") == 1)
        {
            Ball19Buyer.gameObject.SetActive(false);
            Ball[18].color = new Color32(255, 255, 255, 255);
            Stand[18].color = new Color(255, 255, 255, 255);
            priceIcon[18].SetActive(false);
        }

        if (PlayerPrefs.GetInt("equipBall1") == 1)
        {
            Ball1Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(true);
            Ball2Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
            

        }
        if (PlayerPrefs.GetInt("equipBall3") == 1)
        {
            Ball3Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(true);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall2") == 1)
        {
            //
            Ball2Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(true);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall4") == 1)
        {
            //
            Ball4Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(true);
            Ball3Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall5") == 1)
        {
            //
            Ball5Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(true);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall6") == 1)
        {
            //
            Ball6Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(true);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall7") == 1)
        {
            //
            Ball7Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(true);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
           
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall8") == 1)
        {
            //
            Ball8Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(true);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
           
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall9") == 1)
        {
            //
            Ball9Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(true);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall10") == 1)
        {
            //
            Ball10Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(true);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall11") == 1)
        {
            //
            Ball11Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(true);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
           
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall12") == 1)
        {
            //
            Ball12Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(true);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
           
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall13") == 1)
        {
            //
            Ball13Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(true);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall14") == 1)
        {
            //
            Ball14Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(true);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
           
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall15") == 1)
        {
            //
            Ball15Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(true);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
           
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall16") == 1)
        {
            //
            Ball16Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(true);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
          
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall17") == 1)
        {
            //
            Ball17Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(true);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);

            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall18") == 1)
        {
            //
            Ball18Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(true);
            Ball19Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
          
            Ball19Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall19") == 1)
        {
            //
            Ball19Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(true);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            
        }
       

        if (PlayerPrefs.GetInt("equipDefault") == 1)
        {
            //
            Ball2Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball6Equiped.gameObject.SetActive(false);
            Ball7Equiped.gameObject.SetActive(false);
            Ball8Equiped.gameObject.SetActive(false);
            Ball9Equiped.gameObject.SetActive(false);
            Ball10Equiped.gameObject.SetActive(false);
            Ball11Equiped.gameObject.SetActive(false);
            Ball12Equiped.gameObject.SetActive(false);
            Ball13Equiped.gameObject.SetActive(false);
            Ball14Equiped.gameObject.SetActive(false);
            Ball15Equiped.gameObject.SetActive(false);
            Ball16Equiped.gameObject.SetActive(false);
            Ball17Equiped.gameObject.SetActive(false);
            Ball18Equiped.gameObject.SetActive(false);
            Ball19Equiped.gameObject.SetActive(false);
            Ball1Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
            Ball6Equiper.gameObject.SetActive(true);
            Ball7Equiper.gameObject.SetActive(true);
            Ball8Equiper.gameObject.SetActive(true);
            Ball9Equiper.gameObject.SetActive(true);
            Ball10Equiper.gameObject.SetActive(true);
            Ball11Equiper.gameObject.SetActive(true);
            Ball12Equiper.gameObject.SetActive(true);
            Ball13Equiper.gameObject.SetActive(true);
            Ball14Equiper.gameObject.SetActive(true);
            Ball15Equiper.gameObject.SetActive(true);
            Ball16Equiper.gameObject.SetActive(true);
            Ball17Equiper.gameObject.SetActive(true);
            Ball18Equiper.gameObject.SetActive(true);
            Ball19Equiper.gameObject.SetActive(true);
        }

    }


    IEnumerator waitbefore()
    {
        yield return new WaitForSeconds(1.35f);
        WarningPanel.gameObject.SetActive(false);
    }

    IEnumerator waitbeforegems()
    {
        yield return new WaitForSeconds(1.35f);
        WarningPanelGems.gameObject.SetActive(false);
    }

    public void Ball1Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 200)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball1Buyer.gameObject.SetActive(false);
            currentCoin -= 200;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall1 = 1;
            Ball[0].color = new Color32(255, 255, 255, 255);
            Stand[0].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall1", haveBall1);
            Ball1Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball2Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 200)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball2Buyer.gameObject.SetActive(false);
            currentCoin -= 200;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall2 = 1;
            Ball[1].color = new Color32(255, 255, 255, 255);
            Stand[1].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall2", haveBall2);
            Ball2Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball3Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 200)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball3Buyer.gameObject.SetActive(false);
            currentCoin -= 200;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall3 = 1;
            Ball[2].color = new Color32(255, 255, 255, 255);
            Stand[2].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall3", haveBall3);
            Ball3Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball4Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 400)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball4Buyer.gameObject.SetActive(false);
            currentCoin -= 200;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall4 = 1;
            Ball[3].color = new Color32(255, 255, 255, 255);
            Stand[3].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall4", haveBall4);
            Ball4Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball5Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 400)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball5Buyer.gameObject.SetActive(false);
            currentCoin -= 200;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall5 = 1;
            Ball[4].color = new Color32(255, 255, 255, 255);
            Stand[4].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall5", haveBall5);
            Ball5Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball6Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 500)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball6Buyer.gameObject.SetActive(false);
            currentCoin -= 500;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall6 = 1;
            Ball[5].color = new Color32(255, 255, 255, 255);
            Stand[5].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall6", haveBall6);
            Ball6Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball7Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 500)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball7Buyer.gameObject.SetActive(false);
            currentCoin -= 500;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            Ball[6].color = new Color32(255, 255, 255, 255);
            Stand[6].color = new Color(255, 255, 255, 255);
            haveBall7 = 1;
            PlayerPrefs.SetInt("haveBall7", haveBall7);
            Ball7Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball8Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 650)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball8Buyer.gameObject.SetActive(false);
            currentCoin -= 650;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall8= 1;
            Ball[7].color = new Color32(255, 255, 255, 255);
            Stand[7].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall8", haveBall8);
            Ball8Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball9Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 650)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball9Buyer.gameObject.SetActive(false);
            currentCoin -= 650;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall9 = 1;
            Ball[8].color = new Color32(255, 255, 255, 255);
            Stand[8].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall9", haveBall9);
            Ball9Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball10Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 750)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball10Buyer.gameObject.SetActive(false);
            currentCoin -= 750;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall10 = 1;
            Ball[9].color =  new  Color32(255, 255, 255, 255);
            Stand[9].color = new Color(255, 255, 255, 255);
            
            PlayerPrefs.SetInt("haveBall10", haveBall10);
            Ball10Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball11Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 750)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball11Buyer.gameObject.SetActive(false);
            currentCoin -= 750;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall11 = 1;
            Ball[10].color = new Color32(255, 255, 255, 255);
            Stand[10].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall11", haveBall11);
            Ball11Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball12Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 1000)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball12Buyer.gameObject.SetActive(false);
            currentCoin -= 1500;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall12 = 1;
            Ball[11].color = new Color32(255, 255, 255, 255);
            Stand[11].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall12", haveBall12);
            Ball12Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball13Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 1500)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball13Buyer.gameObject.SetActive(false);
            currentCoin -= 2000;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall13 = 1;
            Ball[12].color = new Color32(255, 255, 255, 255);
            Stand[12].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall13", haveBall13);
            Ball13Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball14Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 2000)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball14Buyer.gameObject.SetActive(false);
            currentCoin -= 3000;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall14 = 1;
            Ball[13].color = new Color32(255, 255, 255, 255);
            Stand[13].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall14", haveBall14);
            Ball14Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball15Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 3000)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball15Buyer.gameObject.SetActive(false);
            currentCoin -= 3000;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall15 = 1;
            Ball[14].color = new Color32(255, 255, 255, 255);
            Stand[14].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall15", haveBall15);
            Ball15Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanel.gameObject.SetActive(true);
            StartCoroutine("waitbefore");
        }
    }
    public void Ball16Buy()
    {
        if (PlayerPrefs.GetInt("Diamond") >= 5)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball16Buyer.gameObject.SetActive(false);
            currentGem -= 5;
            PlayerPrefs.SetInt("Diamond", currentGem);
            haveBall16 = 1;
            Ball[15].color = new Color32(255, 255, 255, 255);
            Stand[15].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall16", haveBall16);
            Ball16Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanelGems.gameObject.SetActive(true);
            StartCoroutine("waitbeforegems");
        }
    }
    public void Ball17Buy()
    {
        if (PlayerPrefs.GetInt("Diamond") >= 5)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball17Buyer.gameObject.SetActive(false);
            currentGem -= 5;
            PlayerPrefs.SetInt("Diamond", currentGem);
            haveBall17 = 1;
            Ball[16].color = new Color32(255, 255, 255, 255);
            Stand[16].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall17", haveBall17);
            Ball17Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanelGems.gameObject.SetActive(true);
            StartCoroutine("waitbeforegems");
        }
    }
    public void Ball18Buy()
    {
        if (PlayerPrefs.GetInt("Diamond") >= 10)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball18Buyer.gameObject.SetActive(false);
            currentGem -= 10;
            PlayerPrefs.SetInt("Diamond", currentGem);
            haveBall18 = 1;
            Ball[17].color = new Color32(255, 255, 255, 255);
            Stand[17].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall18", haveBall18);
            Ball18Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanelGems.gameObject.SetActive(true);
            StartCoroutine("waitbeforegems");
        }
    }
    public void Ball19Buy()
    {
        if (PlayerPrefs.GetInt("Diamond") >= 10)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball19Buyer.gameObject.SetActive(false);
            currentGem -= 10;
            PlayerPrefs.SetInt("Diamond", currentGem);
            haveBall19 = 1;
            Ball[18].color = new Color32(255, 255, 255, 255);
            Stand[18].color = new Color(255, 255, 255, 255);
            PlayerPrefs.SetInt("haveBall19", haveBall19);
            Ball19Equiper.gameObject.SetActive(true);
        }
        else
        {
            WarningPanelGems.gameObject.SetActive(true);
            StartCoroutine("waitbeforegems");
        }
    }





  
    public void Ball1Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        
        Ball1Equiped.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(false);
        Ball2Equiper.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 1);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        Ball1Equiper.gameObject.SetActive(false);
    }
    public void Ball2Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball2Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(false);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 1);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball3Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball3Equiper.gameObject.SetActive(false);
        Ball3Equiped.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 1);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
    }
    public void Ball4Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball4Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(false);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 1);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball5Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball5Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(false);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 1);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball6Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball6Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(false);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 1);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball7Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball7Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(false);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 1);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball8Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball8Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(false);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 1);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball9Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball9Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(false);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 1);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball10Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball10Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(false);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 1);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball11Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball11Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(false);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 1);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball12Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball12Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(false);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 1);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball13Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball5Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(false);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 1);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball14Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball14Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(false);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 1);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball15Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball15Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(false);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 1);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball16Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball16Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(false);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 1);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball17Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball17Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(false);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 1);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball18Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball18Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(false);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 1);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void Ball19Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball19Equiped.gameObject.SetActive(true);
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(false);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 1);
        PlayerPrefs.SetInt("equipDefault", 0);

    }
    public void DefaultEquip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        Ball6Equiper.gameObject.SetActive(true);
        Ball7Equiper.gameObject.SetActive(true);
        Ball8Equiper.gameObject.SetActive(true);
        Ball9Equiper.gameObject.SetActive(true);
        Ball10Equiper.gameObject.SetActive(true);
        Ball11Equiper.gameObject.SetActive(true);
        Ball12Equiper.gameObject.SetActive(true);
        Ball13Equiper.gameObject.SetActive(true);
        Ball14Equiper.gameObject.SetActive(true);
        Ball15Equiper.gameObject.SetActive(true);
        Ball16Equiper.gameObject.SetActive(true);
        Ball17Equiper.gameObject.SetActive(true);
        Ball18Equiper.gameObject.SetActive(true);
        Ball19Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(false);
        DefaultSkinEquiped.gameObject.SetActive(true);

        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall6", 0);
        PlayerPrefs.SetInt("equipBall7", 0);
        PlayerPrefs.SetInt("equipBall8", 0);
        PlayerPrefs.SetInt("equipBall9", 0);
        PlayerPrefs.SetInt("equipBall10", 0);
        PlayerPrefs.SetInt("equipBall11", 0);
        PlayerPrefs.SetInt("equipBall12", 0);
        PlayerPrefs.SetInt("equipBall13", 0);
        PlayerPrefs.SetInt("equipBall14", 0);
        PlayerPrefs.SetInt("equipBall15", 0);
        PlayerPrefs.SetInt("equipBall16", 0);
        PlayerPrefs.SetInt("equipBall17", 0);
        PlayerPrefs.SetInt("equipBall18", 0);
        PlayerPrefs.SetInt("equipBall19", 0);
        PlayerPrefs.SetInt("equipDefault", 1);
    }
}