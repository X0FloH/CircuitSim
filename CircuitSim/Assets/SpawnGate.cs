using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGate : MonoBehaviour {

    [Header("Prefabs")]
    public GameObject battery;
    public GameObject and;
    public GameObject or;
    public GameObject inverter;
    public GameObject nor;
    public GameObject xor;
    public GameObject xnor;
    public GameObject nand;
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

    public void SpawnOr()
    {
        GameObject orNew = Instantiate(or, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), or.transform.rotation);
        orNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        orNew.transform.Find("Input1").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        orNew.transform.Find("Input2").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnInverter()
    {
        GameObject inverterNew = Instantiate(inverter, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), inverter.transform.rotation);
        inverterNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        inverterNew.transform.Find("Input").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnNor()
    {
        GameObject norNew = Instantiate(nor, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), nor.transform.rotation);
        norNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        norNew.transform.Find("Input1").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        norNew.transform.Find("Input2").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnXor()
    {
        GameObject xorNew = Instantiate(xor, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), xor.transform.rotation);
        xorNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        xorNew.transform.Find("Input1").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        xorNew.transform.Find("Input2").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnXnor()
    {
        GameObject xnorNew = Instantiate(xnor, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), xnor.transform.rotation);
        xnorNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        xnorNew.transform.Find("Input1").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        xnorNew.transform.Find("Input2").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
    }

    public void SpawnNand()
    {
        GameObject nandNew = Instantiate(nand, new Vector3(transform.position.x + Random.Range(-3f, 3f), transform.position.y + Random.Range(-3f, 3f), 0f), nand.transform.rotation);
        nandNew.transform.Find("Output").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        nandNew.transform.Find("Connection1").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
        nandNew.transform.Find("Connection2").GetComponent<Click>().holdWire = GetComponent<HoldingWire>();
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
