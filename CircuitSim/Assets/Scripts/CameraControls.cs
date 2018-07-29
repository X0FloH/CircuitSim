using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public float scrollSpeed = 1f;
    public float dragSpeed = 0.1f;
    private Vector3 editMSPos = new Vector3(0, 0, -8f);

    private void Update()
    {
        GetComponent<Camera>().orthographicSize += (Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
        GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize, 0.1f, 30f);

        Vector3 mP = Input.mousePosition;
        mP.z = -8f;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(mP);
        if (Input.GetMouseButtonDown(2))
        {
            /*
            editMSPos[0] = mousePos[0]
            editMSPos[1] = mousePos[1]
            */
            editMSPos[0] = mousePos[0];
            editMSPos[1] = mousePos[1];
        }
        if (Input.GetMouseButton(2))
        {
            /*
            editX += mousePos[0]-editMSPos[0]
            editY += mousePos[1]-editMSPos[1]
            editMSPos[0] = mousePos[0]
            editMSPos[1] = mousePos[1]
            */
            transform.position -= (new Vector3(mousePos[0] - editMSPos[0], mousePos[1] - editMSPos[1], 0f)*dragSpeed);
            editMSPos[0] = mousePos[0];
            editMSPos[1] = mousePos[1];
        }
    }
}
