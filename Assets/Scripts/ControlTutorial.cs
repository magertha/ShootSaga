using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public bool tutorialDestroyer;
    public float tutorialFloat;
    void Start()
    {
        tutorialDestroyer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            tutorialDestroyer = true;
        }
        if (tutorialDestroyer == true)
        {
            tutorialFloat += Time.deltaTime;
            if (tutorialFloat >= 1.5f)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}

