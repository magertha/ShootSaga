using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSystem : MonoBehaviour
{
    public int totalGems = 0; // Total amount of Gems earned
    private void Update()
    {
        LoadTotalGems(); // Load the total Gems from PlayerPrefs at game start
    }
    private void Awake()
    {
        //LoadTotalGems(); // Load the total Gems from PlayerPrefs at game start
    }

    // Function to add Gems at the end of a level
    public void AddGems(int amount)
    {
        totalGems += amount;
        SaveTotalGems(); // Save the updated total Gems to PlayerPrefs
    }

    // Save the total Gems to PlayerPrefs
    private void SaveTotalGems()
    {
        PlayerPrefs.SetInt("TotalGems", totalGems);
        PlayerPrefs.Save();
    }

    // Load the total Gems from PlayerPrefs
    private void LoadTotalGems()
    {
        if (PlayerPrefs.HasKey("TotalGems"))
        {
            totalGems = PlayerPrefs.GetInt("TotalGems");
        }
    }
}
