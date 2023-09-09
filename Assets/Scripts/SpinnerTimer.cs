using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SpinnerTimer : MonoBehaviour
{
    public Text Time;
    public float msToWait;
    public Button ClickButton;
    private ulong lastTimeClicked;
    public GameObject spinner;
    public Button spinnerButton;
    public Sprite spriteOn;
    public Sprite spriteOff;
    public static float secondsLeft;
    private void Start()
    {

        lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("LastTimeClicked"));

        if (!Ready())
            ClickButton.interactable = false;
    }

    private void Update()
    {
        if (!ClickButton.IsInteractable())
        {
            spinnerButton.GetComponent<Image>().sprite = spriteOff;
            if (Ready())
            {
                ClickButton.interactable = true;
                Time.text = "Ready!";
                return;
            }
            ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            secondsLeft = (float)(msToWait - m) / 1000.0f;

            string r = "";
            //HOURS
            r += ((int)secondsLeft / 3600).ToString() + "h";
            secondsLeft -= ((int)secondsLeft / 3600) * 3600;
            //MINUTES
            r += ((int)secondsLeft / 60).ToString("00") + "m ";
            //SECONDS
            r += (secondsLeft % 60).ToString("00") + "s";
            Time.text = r;
            Debug.Log(r);

        }
        else
        {
            spinnerButton.GetComponent<Image>().sprite = spriteOn; 
        }
    }


    public void Click()
    {
        lastTimeClicked = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastTimeClicked", lastTimeClicked.ToString());
        ClickButton.interactable = false;
        spinner.SetActive(true);
        

    }
    private bool Ready()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
        ulong m = diff / TimeSpan.TicksPerMillisecond;

        float secondsLeft = (float)(msToWait - m) / 1000.0f;

        
        if (secondsLeft < 0)
        {
            //DO SOMETHING WHEN TIMER IS FINISHED
            return true;
        }

        return false;
    }
}