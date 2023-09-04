using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemDisplay : MonoBehaviour
{
    public TMP_Text totalGemText;
    private GemSystem gemSystem;

    void Update()
    {
        totalGemText.text = PlayerPrefs.GetInt("TotalGems").ToString() + " gems";
    }
}
