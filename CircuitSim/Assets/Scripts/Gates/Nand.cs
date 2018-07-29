using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nand : MonoBehaviour {

    public Connection connection1;
    public Connection connection2;

    public Connection output;

    private void LateUpdate()
    {
        if (connection1.wireConnection[0].logicValue)
        {
            if (connection2.wireConnection[0].logicValue)
            {
                output.overwriteLogic = false;
            }
            else
            {
                output.overwriteLogic = true;
            }
        }
        else
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
