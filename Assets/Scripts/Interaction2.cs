using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction2 : MonoBehaviour
{
    public Animator lavaLe;
    public Animator lavaRi;
    bool isOpen = false;

    void Start()
    {
        lavaLe = lavaLe.GetComponent<Animator>();
        lavaRi = lavaRi.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (isOpen == false)
        {
            isOpen = true;
            lavaLe.Play("Lav2Left");
            lavaRi.Play("Lav2Right");
        }
    }
}
