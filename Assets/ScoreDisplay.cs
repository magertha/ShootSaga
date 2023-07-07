using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scor;
    public ContestMain conmain;
    void Start()
    {
        scor.text = "Your Score:  " + conmain.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
