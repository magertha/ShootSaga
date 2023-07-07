using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        Destroy(gameObject, 1.5f);
    }
}
