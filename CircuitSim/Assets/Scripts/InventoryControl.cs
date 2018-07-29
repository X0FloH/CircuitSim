using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControl : MonoBehaviour {

    public RectTransform openedShop;
    public RectTransform closedShop;

    public bool opening = false;
    public bool closing = true;

    public float speed;

    private void Update()
    {
        if (closing)
        {
            GetComponent<RectTransform>().position = Vector3.Lerp(GetComponent<RectTransform>().position, closedShop.GetComponent<RectTransform>().position, speed * Time.deltaTime);
        }
        if (opening)
        {
            GetComponent<RectTransform>().position = Vector3.Lerp(GetComponent<RectTransform>().position, openedShop.GetComponent<RectTransform>().position, speed * Time.deltaTime);
        }
    }

    public void OpenShop()
    {
        closing = false;
        opening = true;
    }

    public void CloseShop()
    {
        opening = false;
        closing = true;
    }
}
