using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelCleared : MonoBehaviour
{
    public bool LC = false;
    public CoinSystem coinSystem;
    public TMP_Text coinText;
    public int coinsEarned = 10; 
    public OutOfMovesScreen outofm;
    public GameOverScreen over;
    public GameObject cleared;
    //public Counter counter;
    //public int multiplier; 
    public void Start()
    {
        
    }
    
    public void Next()
    {
        if (outofm.OOM == false && over.GO == false)
        {
            LC = true;
            cleared.SetActive(true);
            //multiplier = counter.count + 1;
            coinSystem.AddCoins(coinsEarned);
            coinText.text = "+ " + coinsEarned.ToString() + " coins";
        }
    }
}
