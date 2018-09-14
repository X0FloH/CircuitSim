using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubMenu : MonoBehaviour {

    public RectTransform arrow;
    public float speed;
    public List<GameObject> subMenuItems = new List<GameObject>();

    public GameObject closedLookAt;
    public GameObject openedLookAt;
    public GameObject lookAtOBJ;

    public bool opened;
    public bool closed = true;

    private void Update()
    {
        if (closed == true)
        {
            arrow.GetComponent<RectTransform>().LookAt(lookAtOBJ.transform.position);
            foreach(GameObject menuItem in subMenuItems)
            {
                menuItem.GetComponent<Image>().color = Color.Lerp(menuItem.GetComponent<Image>().color, new Color(menuItem.GetComponent<Image>().color.r, menuItem.GetComponent<Image>().color.g, menuItem.GetComponent<Image>().color.b, 0f), speed * Time.deltaTime);
                if (menuItem.transform.Find("Image") != null)
                {
                    GameObject menuItemChild = menuItem.transform.Find("Image").gameObject;
                    menuItemChild.GetComponent<Image>().color = Color.Lerp(menuItemChild.GetComponent<Image>().color, new Color(menuItemChild.GetComponent<Image>().color.r, menuItemChild.GetComponent<Image>().color.g, menuItemChild.GetComponent<Image>().color.b, 0f), speed * Time.deltaTime);
                }
                else
                {
                    foreach (Transform child in menuItem.transform)
                    {
                        if (child.name == "Button")
                        {
                            child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color, new Color(child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color.r, child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color.g, child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                            child.Find("ButtonRight").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("ButtonRight").GetComponent<SpriteRenderer>().color, new Color(child.Find("ButtonRight").GetComponent<SpriteRenderer>().color.r, child.Find("ButtonRight").GetComponent<SpriteRenderer>().color.g, child.Find("ButtonRight").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                            child.Find("ButtonOff").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("ButtonOff").GetComponent<SpriteRenderer>().color, new Color(child.Find("ButtonOff").GetComponent<SpriteRenderer>().color.r, child.Find("ButtonOff").GetComponent<SpriteRenderer>().color.g, child.Find("ButtonOff").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                            child.Find("Input").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("Input").GetComponent<SpriteRenderer>().color, new Color(child.Find("Input").GetComponent<SpriteRenderer>().color.r, child.Find("Input").GetComponent<SpriteRenderer>().color.g, child.Find("Input").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                            child.Find("Output").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("Output").GetComponent<SpriteRenderer>().color, new Color(child.Find("Output").GetComponent<SpriteRenderer>().color.r, child.Find("Output").GetComponent<SpriteRenderer>().color.g, child.Find("Output").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                        }
                        else
                        {
                            if (child.name == "LED")
                            {
                                child.Find("InputLeg").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("InputLeg").GetComponent<SpriteRenderer>().color, new Color(child.Find("InputLeg").GetComponent<SpriteRenderer>().color.r, child.Find("InputLeg").GetComponent<SpriteRenderer>().color.g, child.Find("InputLeg").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                                child.Find("Input (1)").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("Input (1)").GetComponent<SpriteRenderer>().color, new Color(child.Find("Input (1)").GetComponent<SpriteRenderer>().color.r, child.Find("Input (1)").GetComponent<SpriteRenderer>().color.g, child.Find("Input (1)").GetComponent<SpriteRenderer>().color.b, 0f), speed * Time.deltaTime);
                            }
                            else
                            {
                                if (child.name == "Cover")
                                {
                                    child.GetComponent<Image>().color = Color.Lerp(child.GetComponent<Image>().color, new Color(child.GetComponent<Image>().color.r, child.GetComponent<Image>().color.g, child.GetComponent<Image>().color.b, 1f), speed * Time.deltaTime);
                                }
                                else
                                {
                                    child.gameObject.SetActive(true);
                                }
                            }
                        }
                    }
                }
            }
        }
        if(opened == true)
        {
            arrow.GetComponent<RectTransform>().LookAt(lookAtOBJ.transform.position);
            foreach (GameObject menuItem in subMenuItems)
            {
                menuItem.GetComponent<Image>().color = Color.Lerp(menuItem.GetComponent<Image>().color, new Color(menuItem.GetComponent<Image>().color.r, menuItem.GetComponent<Image>().color.g, menuItem.GetComponent<Image>().color.b, 1f), speed * Time.deltaTime);
                if (menuItem.transform.Find("Image") != null)
                {
                    GameObject menuItemChild = menuItem.transform.Find("Image").gameObject;
                    menuItemChild.GetComponent<Image>().color = Color.Lerp(menuItemChild.GetComponent<Image>().color, new Color(menuItemChild.GetComponent<Image>().color.r, menuItemChild.GetComponent<Image>().color.g, menuItemChild.GetComponent<Image>().color.b, 1f), speed * Time.deltaTime);
                } else
                {
                    foreach(Transform child in menuItem.transform)
                    {
                        if(child.name == "Button")
                        {
                            child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color, new Color(child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color.r, child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color.g, child.Find("ButtonMainLeft").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                            child.Find("ButtonRight").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("ButtonRight").GetComponent<SpriteRenderer>().color, new Color(child.Find("ButtonRight").GetComponent<SpriteRenderer>().color.r, child.Find("ButtonRight").GetComponent<SpriteRenderer>().color.g, child.Find("ButtonRight").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                            child.Find("ButtonOff").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("ButtonOff").GetComponent<SpriteRenderer>().color, new Color(child.Find("ButtonOff").GetComponent<SpriteRenderer>().color.r, child.Find("ButtonOff").GetComponent<SpriteRenderer>().color.g, child.Find("ButtonOff").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                            child.Find("Input").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("Input").GetComponent<SpriteRenderer>().color, new Color(child.Find("Input").GetComponent<SpriteRenderer>().color.r, child.Find("Input").GetComponent<SpriteRenderer>().color.g, child.Find("Input").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                            child.Find("Output").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("Output").GetComponent<SpriteRenderer>().color, new Color(child.Find("Output").GetComponent<SpriteRenderer>().color.r, child.Find("Output").GetComponent<SpriteRenderer>().color.g, child.Find("Output").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                        } else
                        {
                            if(child.name == "LED")
                            {
                                child.Find("InputLeg").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("InputLeg").GetComponent<SpriteRenderer>().color, new Color(child.Find("InputLeg").GetComponent<SpriteRenderer>().color.r, child.Find("InputLeg").GetComponent<SpriteRenderer>().color.g, child.Find("InputLeg").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                                child.Find("Input (1)").GetComponent<SpriteRenderer>().color = Color.Lerp(child.Find("Input (1)").GetComponent<SpriteRenderer>().color, new Color(child.Find("Input (1)").GetComponent<SpriteRenderer>().color.r, child.Find("Input (1)").GetComponent<SpriteRenderer>().color.g, child.Find("Input (1)").GetComponent<SpriteRenderer>().color.b, 1f), speed * Time.deltaTime);
                            }
                            else
                            {
                                if(child.name == "Cover")
                                {
                                    child.GetComponent<Image>().color = Color.Lerp(child.GetComponent<Image>().color, new Color(child.GetComponent<Image>().color.r, child.GetComponent<Image>().color.g, child.GetComponent<Image>().color.b, 0f), speed * Time.deltaTime);
                                }
                                else
                                {
                                    child.gameObject.SetActive(true);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void LateUpdate()
    {
        if (closed == true)
        {
            lookAtOBJ.transform.position = Vector3.Lerp(lookAtOBJ.transform.position, closedLookAt.transform.position, speed * Time.deltaTime);
        }
        if(opened == true)
        {
            lookAtOBJ.transform.position = Vector3.Lerp(lookAtOBJ.transform.position, openedLookAt.transform.position, speed * Time.deltaTime);
        }
    }

    public void ToggleSubMenu()
    {
        if(opened == true)
        {
            closed = true;
            opened = false;

        } else
        {
            opened = true;
            closed = false;
        }
    }
}
