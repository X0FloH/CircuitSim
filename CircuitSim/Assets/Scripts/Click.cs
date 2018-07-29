using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public GameObject wirePrefab;

    public HoldingWire holdWire;

    public bool recieving;

    private void OnMouseDown()
    {
        if (!recieving)
        {
            if (!holdWire.holding)
            {
                GameObject newWire = Instantiate(wirePrefab, Vector3.zero, Quaternion.identity);
                newWire.GetComponent<LineRenderer>().SetPosition(0, transform.position);
                holdWire.currentWire = newWire;
                GetComponent<Connection>().wireConnection.Add(newWire.GetComponent<Wire>());
                holdWire.currentWire.GetComponent<LockTo>().startConnectedTo = transform.gameObject;
                holdWire.holding = true;
            }
        }
        else
        {
            if (holdWire.holding)
            {
                GetComponent<Connection>().wireConnection.Add(holdWire.currentWire.GetComponent<Wire>());
                holdWire.currentWire.GetComponent<LineRenderer>().SetPosition(1, transform.position);
                holdWire.currentWire.GetComponent<LockTo>().endConnectedTo = transform.gameObject;
                holdWire.currentWire.GetComponent<LockTo>().lockNow = true;
                holdWire.holding = false;
            }
        }
    }
}
