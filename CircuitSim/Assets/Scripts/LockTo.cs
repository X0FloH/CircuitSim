using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTo : MonoBehaviour {

    public bool lockNow;
    public GameObject endConnectedTo;
    public GameObject startConnectedTo;
    public GameObject curvePoint;

    int numPoints = 50;
    Vector3[] positions = new Vector3[50];

    private void Update()
    {
        if (lockNow)
        {
            GetComponent<LineRenderer>().positionCount = numPoints;
            // curvePoint.transform.position = startConnectedTo.transform.position + (endConnectedTo.transform.position - startConnectedTo.transform.position) / 2;
            curvePoint.transform.position = new Vector3(startConnectedTo.transform.position.x + (endConnectedTo.transform.position.x - startConnectedTo.transform.position.x) / 2, endConnectedTo.transform.position.y, curvePoint.transform.position.z);
            for (int i = 1; i < numPoints + 1; i++)
            {
                float t = i / (float)numPoints;
                positions[i - 1] = CalculateQuadraticBezierPoint(t, startConnectedTo.transform.position, curvePoint.transform.position, endConnectedTo.transform.position);
            }
            GetComponent<LineRenderer>().SetPositions(positions);
            GetComponent<LineRenderer>().SetPosition(0, startConnectedTo.transform.position);
        }
    }

    Vector3 CalculateQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector3 p = uu * p0;
        p += 2 * u * t * p1;
        p += tt * p2;
        return p;
    }
}
