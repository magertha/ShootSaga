using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction2 : MonoBehaviour
{
    public Animator lavaLe;
    public Animator lavaRi;
    public Animator button2;
    bool isOpen = false;

    void Start()
    {
        lavaLe = lavaLe.GetComponent<Animator>();
        lavaRi = lavaRi.GetComponent<Animator>();
        button2 = button2.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (isOpen == false)
        {
            isOpen = true;
            lavaLe.Play("Lav2Left");
            lavaRi.Play("Lav2Right");
            button2.Play("Lv15B2");
        }
    }
}
