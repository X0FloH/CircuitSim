using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingWire : MonoBehaviour {

    public bool holding;

    public GameObject currentWire;

    int numPoints = 50;
    Vector3[] positions = new Vector3[50];

    private void Update()
    {
        if (holding)
        {
            Vector3 mP = Input.mousePosition;
            mP.z = 8f;
            Vector3 position = Camera.main.ScreenToWorldPoint(mP);
            currentWire.GetComponent<LineRenderer>().positionCount = numPoints;
            GameObject curvePoint = currentWire.transform.Find("CurvePoint").gameObject;
            Vector3 startConnectedTo = currentWire.GetComponent<LockTo>().startConnectedTo.transform.position;
            Vector3 endConnectedTo = position;
            // curvePoint.transform.position = startConnectedTo.transform.position + (endConnectedTo.transform.position - startConnectedTo.transform.position) / 2;
            curvePoint.transform.position = new Vector3(startConnectedTo.x + (endConnectedTo.x - startConnectedTo.x) / 2, endConnectedTo.y, curvePoint.transform.position.z);
            for (int i = 1; i < numPoints + 1; i++)
            {
                float t = i / (float)numPoints;
                positions[i - 1] = CalculateQuadraticBezierPoint(t, startConnectedTo, curvePoint.transform.position, endConnectedTo);
            }
            currentWire.GetComponent<LineRenderer>().SetPositions(positions);
            currentWire.GetComponent<LineRenderer>().SetPosition(0, startConnectedTo);
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
