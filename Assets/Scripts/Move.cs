using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, 1.5f);
    }
}
