using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinDisplay : MonoBehaviour
{
    public TMP_Text totalCoinText;
    private CoinSystem coinSystem;

    void Update()
    {
        totalCoinText.text = PlayerPrefs.GetInt("TotalCoins").ToString() + " coins";
    }
}
