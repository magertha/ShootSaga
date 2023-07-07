using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource Click;
    public AudioSource Bounce;
    public AudioSource Net;

    public void PlayClick()
    {
        Click.Play();
    }

    public void PlayBounce()
    {
        Bounce.Play();
    }

    public void PlayNet()
    {
        Net.Play();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Net.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bounce.Play();
    }

}

