using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSoundScript : MonoBehaviour
{
    private GameObject[] music;

    void Start()
    {
        music = GameObject.FindGameObjectsWithTag("GameMusic");
        Destroy (music[1]);
    }
    
    void Awake()
    {
        DontDestroyOnLoad (transform.gameObject);
    }
}