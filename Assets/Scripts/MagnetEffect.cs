using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MagnetEffect : MonoBehaviour
{
    private Transform ballTransform;
    Rigidbody2D rb;
    public float influenceRange;
    public float intensity;
    public float distanceToPlayer;
    Vector2 pullForce;

    // Start is called before the first frame update
    void Start()
    {
        ballTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        rb = ballTransform.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector2.Distance(ballTransform.position, transform.position);
        if (distanceToPlayer <= influenceRange)
        {
            pullForce = (transform.position - ballTransform.position).normalized / distanceToPlayer * intensity;
            rb.AddForce(pullForce, ForceMode2D.Force);
        }
    }
}
