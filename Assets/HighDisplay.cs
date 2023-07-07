using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighDisplay : MonoBehaviour
{
    public TMP_Text high;
    public ContestMain conmain;
    void Start()
    {
        high.text = "High Score:  " + PlayerPrefs.GetInt("high", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
