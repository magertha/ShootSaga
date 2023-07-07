using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class Right3 : MonoBehaviour
{
    public int touches;
    OutOfMovesScreen outOfMovesScreen;
    //LevelControl levelControl;
    public int touchLimiter;
    public BallControl ballControl;

    void Start()
    {
        BallControl.inputen = true;
        outOfMovesScreen =GameObject.FindGameObjectWithTag("OutOfMovesScreen").GetComponent<OutOfMovesScreen>();
        
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2f);

        outOfMovesScreen.Setup();

        //(bullet.GetComponent(bulletres) as MonoBehaviour).enabled = false;

        //(lava.GetComponent(bulletres) as MonoBehaviour).enabled = false;

        //(lava2.GetComponent(bulletres) as MonoBehaviour).enabled = false;
    }

    IEnumerator EXAT()
    {
        yield return new WaitForSeconds(0f);

        touches = touches + 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(EXAT());
        }
        
        if (touches >= touchLimiter)
        {
            BallControl.inputen = false;
            //GameObject.FindGameObjectWithTag("Player").GetComponent<BallControl>().enabled = false;

        }

        if (touches >= touchLimiter)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity.sqrMagnitude < .1)
            {
                StartCoroutine(ExecuteAfterTime());
            }
        }
    }
}
