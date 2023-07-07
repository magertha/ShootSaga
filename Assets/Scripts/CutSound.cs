using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSound : MonoBehaviour
{
    public AudioSource Cut;

    void OnTriggerEnter2D(Collider2D other)
    {
        Cut.Play();
    }
}
