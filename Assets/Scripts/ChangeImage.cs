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
        if (gamemusic.volume == 0)
        {
            button.image.sprite = soundOffImage;
        }
        if (gamemusic.volume == 0.4f)
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
        if (isOn == true)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            gamemusic.volume = 0;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            gamemusic.volume = 0.4f;
        }
    }
}
