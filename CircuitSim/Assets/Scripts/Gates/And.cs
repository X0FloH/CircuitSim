using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And : MonoBehaviour {

    public Connection connection1;
    public Connection connection2;

    public Connection output;

    private void Update()
    {
        if (connection1.wireConnection[0].logicValue)
        {
            if (connection2.wireConnection[0].logicValue)
            {
                output.overwriteLogic = true;
            }
            else
            {
                output.overwriteLogic = false;
            }
        }  else
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
