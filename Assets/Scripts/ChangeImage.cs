using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    public AudioSource gamemusic;
    static bool isOn = true;


    void Start()
    {
        if (AudioManager.Instance.MusicSource.mute)
        {
            button.image.sprite = soundOffImage;
        }
        else 
        {
            button.image.sprite = soundOnImage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        AudioManager.Instance.PlaySFX("Click");
        if (isOn == true)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            AudioManager.Instance.MusicSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioManager.Instance.MusicSource.mute = false;
        }
    }
}
