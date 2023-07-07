using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Animator lavaL;
    public Animator lavaR;
    public Animator platform;
    bool isOpen = false;

    void Start()
    {
        lavaL = lavaL.GetComponent<Animator>();
        lavaR = lavaR.GetComponent<Animator>();
        platform = platform.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(isOpen == false)
        {
            isOpen = true;
            lavaL.Play("LavLeft");
            lavaR.Play("LavRight");
            platform.Play("PlRight");
        }
    }
}
