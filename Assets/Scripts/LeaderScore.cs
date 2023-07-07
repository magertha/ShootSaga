using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LeaderScore : MonoBehaviour
{
    PlayFabManager playFabManager;
    // Start is called before the first frame update
    void Start()
    {
        playFabManager = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<PlayFabManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
