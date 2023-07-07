using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        Destroy(gameObject, 1.5f);
    }

}
