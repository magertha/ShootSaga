using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        Destroy(gameObject, 1.5f);
    }
}
