using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinBuy : MonoBehaviour
{
    private int currentCoin;
    public Button Ball1Buyer,Ball1Equiper,Ball1Equiped;
    public Button Ball2Buyer,Ball2Equiper,Ball2Equiped;
    public Button Ball3Buyer,Ball3Equiper,Ball3Equiped;
    public Button Ball4Buyer, Ball4Equiper, Ball4Equiped;
    public Button Ball5Buyer, Ball5Equiper, Ball5Equiped;
    public Button DefaultSkinEquiper, DefaultSkinEquiped;
    public int haveBall1, haveBall2, haveBall3, haveBall4, haveBall5, equipBall1,equipBall2,equipBall3,equipBall4, equipBall5, equipDefault;
    // Start is called before the first frame update
    void Start()
    {
        currentCoin = PlayerPrefs.GetInt("TotalCoins", 0);
        PlayerPrefs.GetInt("haveBall1", 0);
        PlayerPrefs.GetInt("haveBall3", 0);
        PlayerPrefs.GetInt("haveBall2", 0);
        PlayerPrefs.GetInt("haveBall4", 0);
        PlayerPrefs.GetInt("haveBall5", 0);
        PlayerPrefs.GetInt("equipBall1", 0);
        PlayerPrefs.GetInt("equipBall3", 0);
        PlayerPrefs.GetInt("equipBall2", 0);
        PlayerPrefs.GetInt("equipBall4", 0);
        PlayerPrefs.GetInt("equipBall5", 0);
        PlayerPrefs.GetInt("equipDefault", 0);
    }

    // Update is called once per frame
    void Update()
    {
        currentCoin = PlayerPrefs.GetInt("TotalCoins");
        if (PlayerPrefs.GetInt("haveBall1") == 1)
        {
            Ball1Buyer.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall3") == 1)
        {
            Ball3Buyer.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall2") == 1)
        {
            Ball2Buyer.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall4") == 1)
        {
            Ball4Buyer.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("haveBall5") == 1)
        {
            Ball5Buyer.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("equipBall1") == 1)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball1Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(true);
            Ball2Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall3") == 1)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball3Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(true);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall2") == 1)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball2Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(true);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall4") == 1)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball4Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(true);
            Ball3Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipBall5") == 1)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball5Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(true);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            DefaultSkinEquiper.gameObject.SetActive(true);
            Ball1Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("equipDefault") == 1)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball2Equiper.gameObject.SetActive(false);
            Ball1Equiped.gameObject.SetActive(false);
            Ball2Equiped.gameObject.SetActive(false);
            Ball3Equiped.gameObject.SetActive(false);
            Ball4Equiped.gameObject.SetActive(false);
            Ball5Equiped.gameObject.SetActive(false);
            Ball1Equiper.gameObject.SetActive(true);
            Ball3Equiper.gameObject.SetActive(true);
            Ball2Equiper.gameObject.SetActive(true);
            Ball4Equiper.gameObject.SetActive(true);
            Ball5Equiper.gameObject.SetActive(true);
        }

    }




    public void Ball1Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 200)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball1Buyer.gameObject.SetActive(false);
            currentCoin -= 100;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall1 = 1;
            PlayerPrefs.SetInt("haveBall1", haveBall1);
            Ball1Equiper.gameObject.SetActive(true);
        }
    }
    public void Ball2Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 500)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball2Buyer.gameObject.SetActive(false);
            currentCoin -= 300;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall2 = 1;
            PlayerPrefs.SetInt("haveBall2", haveBall2);
            Ball2Equiper.gameObject.SetActive(true);
        }
    }
    public void Ball3Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 1000)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball3Buyer.gameObject.SetActive(false);
            currentCoin -= 500;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall3 = 1;
            PlayerPrefs.SetInt("haveBall3", haveBall3);
            Ball3Equiper.gameObject.SetActive(true);
        }
    }
    public void Ball4Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 2500)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball4Buyer.gameObject.SetActive(false);
            currentCoin -= 800;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall4 = 1;
            PlayerPrefs.SetInt("haveBall4", haveBall4);
            Ball4Equiper.gameObject.SetActive(true);
        }
    }
    public void Ball5Buy()
    {
        if (PlayerPrefs.GetInt("TotalCoins") >= 4000)
        {
            AudioManager.Instance.PlaySFX("Click");
            Ball5Buyer.gameObject.SetActive(false);
            currentCoin -= 1500;
            PlayerPrefs.SetInt("TotalCoins", currentCoin);
            haveBall5 = 1;
            PlayerPrefs.SetInt("haveBall5", haveBall5);
            Ball5Equiper.gameObject.SetActive(true);
        }
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
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 1);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
    }
    public void Ball1Equip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiped.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 1);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
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
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 1);

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
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 1);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);

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
        DefaultSkinEquiper.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 1);
        PlayerPrefs.SetInt("equipDefault", 0);
        PlayerPrefs.SetInt("equipBall2", 0);

    }
    public void DefaultEquip()
    {
        AudioManager.Instance.PlaySFX("Click");
        Ball3Equiper.gameObject.SetActive(true);
        Ball1Equiper.gameObject.SetActive(true);
        Ball2Equiper.gameObject.SetActive(true);
        Ball4Equiper.gameObject.SetActive(true);
        Ball5Equiper.gameObject.SetActive(true);
        DefaultSkinEquiper.gameObject.SetActive(false);
        DefaultSkinEquiped.gameObject.SetActive(true);
        PlayerPrefs.SetInt("equipBall3", 0);
        PlayerPrefs.SetInt("equipBall1", 0);
        PlayerPrefs.SetInt("equipBall2", 0);
        PlayerPrefs.SetInt("equipBall4", 0);
        PlayerPrefs.SetInt("equipBall5", 0);
        PlayerPrefs.SetInt("equipDefault", 1);
    }
}