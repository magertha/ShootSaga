using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public int totalCoins = 0; // Total amount of coins earned

    private void Awake()
    {
        LoadTotalCoins(); // Load the total coins from PlayerPrefs at game start
    }

    // Function to add coins at the end of a level
    public void AddCoins(int amount)
    {
        totalCoins += amount;
        SaveTotalCoins(); // Save the updated total coins to PlayerPrefs
    }

    // Save the total coins to PlayerPrefs
    private void SaveTotalCoins()
    {
        PlayerPrefs.SetInt("TotalCoins", totalCoins);
        PlayerPrefs.Save();
    }

    // Load the total coins from PlayerPrefs
    private void LoadTotalCoins()
    {
        if (PlayerPrefs.HasKey("TotalCoins"))
        {
            totalCoins = PlayerPrefs.GetInt("TotalCoins");
        }
    }
}
