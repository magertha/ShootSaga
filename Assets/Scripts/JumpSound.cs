using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioSource Boing;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Boing.Play();
    }
}
