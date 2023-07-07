using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryLine : MonoBehaviour
{
    public LineRenderer lr;
    public float maxTrajectoryHeightRatio = 0.5f; // Maximum height ratio relative to the screen height

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void RenderLine(Vector3 startPoint, Vector3 endPoint)
    {
        // Get the screen height and calculate the maximum allowed height
        float screenHeight = Camera.main.orthographicSize * 1.8f;
        float maxTrajectoryHeight = screenHeight * maxTrajectoryHeightRatio;

        // Calculate the scaled height
        float scaledEndY = Mathf.Min(endPoint.y, startPoint.y + maxTrajectoryHeight);

        lr.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = startPoint;
        points[1] = new Vector3(endPoint.x, scaledEndY, endPoint.z);

        lr.SetPositions(points);
    }

    public void EndLine()
    {
        lr.positionCount = 0;
    }
}


    //public LineRenderer lr;

    // private void Awake()
    // {
    //     lr = GetComponent<LineRenderer>();
    // }

    // public void RenderLine(Vector3 startPoint, Vector3 endPoint)
    // {
    //     // Calculate the scaled height
    //     float scaledEndY = endPoint.y - (endPoint.y - startPoint.y) / 2.9f;

    //     lr.positionCount = 2;
    //     Vector3[] points = new Vector3[2];
    //     points[0] = startPoint;
    //     points[1] = new Vector3(endPoint.x, scaledEndY, endPoint.z);

    //     lr.SetPositions(points); 
    // }

    // public void EndLine()
    // {
    //     lr.positionCount = 0;
    // }