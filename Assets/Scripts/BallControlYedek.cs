using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControlYedek : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public float minDragDistance = 0f;
    public float maxDragDistance = 5f;

    public float minPower = 1f;
    public float maxPower = 10f;

    public TrajectoryLine tl;

    private Camera cam;
    private Vector3 startPoint;
    private Vector3 endPoint;
    private float dragDistance;

    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;

            dragDistance = Vector3.Distance(startPoint, currentPoint);
            dragDistance = Mathf.Clamp(dragDistance, minDragDistance, maxDragDistance);

            tl.RenderLine(startPoint, currentPoint * 1.16f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;

            float normalizedDrag = Mathf.InverseLerp(minDragDistance, maxDragDistance, dragDistance);
            float shotPower = Mathf.Lerp(minPower, maxPower, normalizedDrag);

            Vector2 force = new Vector2(endPoint.x - startPoint.x, endPoint.y - startPoint.y).normalized;
            rb.AddForce(force * shotPower, ForceMode2D.Impulse);

            tl.EndLine();
        }
    }
}
