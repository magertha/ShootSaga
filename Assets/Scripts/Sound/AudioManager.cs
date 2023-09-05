using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] MusicSounds, SFXSounds;
    public AudioSource MusicSource, SFXSource;
    public Sprite soundOnImage;
    public Sprite soundOffImage;

    private void Update()
    {
        Debug.Log( PlayerPrefs.GetInt("Music"));
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AudioManager.Instance.PlayMusic("Music");
        
        //PlayerPrefs.GetInt("Music");
        //PlayerPrefs.GetInt("SFX");

        //if (PlayerPrefs.GetInt("Music") == 0)
        //{
        //    MusicSource.mute = false;
        //}
        //else
        //{
        //    MusicSource.mute = true;
        //}

        //if (PlayerPrefs.GetInt("SFX") == 0)
        //{
        //    SFXSource.mute = false;
        //}
        //else
        //{
        //    SFXSource.mute = true;
        //}
    }
    
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(MusicSounds, x => x.Name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            MusicSource.clip = s.Clip;
            MusicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(SFXSounds, x => x.Name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            SFXSource.PlayOneShot(s.Clip);
        }
    }

    public void ToggleMusic()
    {
        MusicSource.mute = !MusicSource.mute;
        //if (MusicSource.mute)
        //{
        //    PlayerPrefs.SetInt("Music", 1);
        //}
        //else
        //{
        //    PlayerPrefs.SetInt("Music", 0);
        //}
    }

    public void ToggleSFX()
    {
        SFXSource.mute = !SFXSource.mute;

        //if (SFXSource.mute)
        //{
        //    PlayerPrefs.SetInt("SFX", 1);
        //}
        //else
        //{
        //    PlayerPrefs.SetInt("SFX", 0);
        //}
    }
}