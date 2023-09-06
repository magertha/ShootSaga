using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopGemDisplay : MonoBehaviour
{
    public TMP_Text totalGemText;
    private GemSystem gemSystem;

    void Update()
    {
        totalGemText.text = PlayerPrefs.GetInt("Diamond").ToString();
    }
}
