using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public Connection input;
    public Connection output;

    public GameObject off;
    public GameObject on;

    public bool currentLogic;

    private void OnMouseDown()
    {
        if (currentLogic)
        {
            currentLogic = false;
        }
        else
        {
            currentLogic = true;
        }
        
    }

    private void Update()
    {
        if (input.wireConnection[0].logicValue)
        {
            if (currentLogic)
            {
                output.overwriteLogic = true;
            } else
            {
                output.overwriteLogic = false;
            }
        } else
        {
            output.overwriteLogic = false;
        }

    }

    private void LateUpdate()
    {
        if (currentLogic)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        else
        {
            on.SetActive(false);
            off.SetActive(true);
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
