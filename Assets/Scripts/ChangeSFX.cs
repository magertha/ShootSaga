using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSFX : MonoBehaviour
{
    public Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    static bool isOn = true;

    void Start()
    {
        if (AudioListener.volume == 0)
        {
            button.image.sprite = soundOffImage;
        }
        if (AudioListener.volume == 1)
        {
            button.image.sprite = soundOnImage;
        }
    }

    public void ButtonClicked()
    {
        if (isOn == true)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            AudioListener.volume = 0;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioListener.volume = 1;
        }
    }
}
