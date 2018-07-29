using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Or : MonoBehaviour {

    public Connection in1;
    public Connection in2;

    public Connection output;

    private void Update()
    {
        if(in1.wireConnection[0].logicValue || in2.wireConnection[0].logicValue)
        {
            output.overwriteLogic = true;
        } else
        {
            output.overwriteLogic = false;
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
