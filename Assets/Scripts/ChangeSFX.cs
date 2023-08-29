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
        if (AudioManager.Instance.SFXSource.mute)
        {
            button.image.sprite = soundOffImage;
        }
        else
        {
            button.image.sprite = soundOnImage;
        }
    }

    public void ButtonClicked()
    {
        AudioManager.Instance.PlaySFX("Click");
        if (isOn == true)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            AudioManager.Instance.SFXSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioManager.Instance.SFXSource.mute = false;
        }
    }
}
