using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour {

    public List<Wire> wireConnection = new List<Wire>();

    public bool overwrite;
    public bool overwriteLogic;

    private void Update()
    {
        if (overwrite)
        {
            foreach (Wire wireObj in wireConnection)
            {
                wireObj.logicValue = overwriteLogic;
            }
        }
    }
}
