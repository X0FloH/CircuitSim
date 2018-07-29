using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGate : MonoBehaviour {

    [Header("Prefabs")]
    public GameObject battery;
    public GameObject and;
    public GameObject button;
    public GameObject led;

    public void SpawnBattery()
    {
        GameObject batteryNew = Instantiate(battery, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), battery.transform.rotation);
        batteryNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnAnd()
    {
        GameObject andNew = Instantiate(and, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), and.transform.rotation);
        andNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        andNew.transform.Find("Connection1").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        andNew.transform.Find("Connection2").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnButton()
    {
        GameObject buttonNew = Instantiate(button, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), button.transform.rotation);
        buttonNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        buttonNew.transform.Find("Input").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnLED()
    {
        GameObject ledNew = Instantiate(led, new Vector3(transform.position.x + Random.Range(-3, 3), transform.position.y + Random.Range(-3, 3), 0f), led.transform.rotation);
        ledNew.transform.Find("Input (1)").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }
}
