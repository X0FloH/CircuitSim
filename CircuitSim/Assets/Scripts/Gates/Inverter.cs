using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : MonoBehaviour {

    public Connection input;
    public Connection output;

    private void Update()
    {
        if (input.wireConnection[0].logicValue)
        {
            output.overwriteLogic = false;
        } else
        {
            output.overwriteLogic = true;
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
