using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    GameObject ball;
    static bool oneTime;

    // Start is called before the first frame update
    void Start()
    {
        oneTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ball == null && oneTime == false)
        {
            ball = GameObject.FindGameObjectWithTag("Player");
        }
        else
        {
            oneTime = true;
        }
        transform.position = new Vector2(transform.position.x, ball.transform.position.y + 4);
    }
}
