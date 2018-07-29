using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour {

    public Connection input;

    private void Update()
    {
        if (input.wireConnection[0].logicValue)
        {
            gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_BE2A8F68", 1);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_BE2A8F68", 0);
        }
    }

    private void OnMouseDrag()
    {
        Vector3 mP = Input.mousePosition;
        mP.z = 8f;
        Vector3 pos = Camera.main.ScreenToWorldPoint(mP);
        transform.position = pos;
    }
}
