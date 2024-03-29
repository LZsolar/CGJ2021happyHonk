﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInteraction : MonoBehaviour
{
    public Inventory inventory;
    public TextMeshProUGUI pickupText;
    public MenuPhone getStatusPhone;
    bool inRange = false;
    Collider2D thisItem;

    void Start()
    {
        pickupText.text = "";
    }

    void Update()
    {
        if(inRange)
        {
            if(Input.GetKeyDown(KeyCode.E) && thisItem.GetComponent<ItemData>().itemInfo.type == itemType.Pickable && !getStatusPhone.ActivePhone)
            {
                inventory.itemInInventory.Add(thisItem.transform.GetComponent<ItemData>().itemInfo);
                inventory.itemReference.Add(thisItem);
                thisItem.transform.position = new Vector3(-100f, -100f, 0f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.CompareTag("Item"))
        {
            if(col.GetComponent<ItemData>().itemInfo.type == itemType.Pickable && col.transform.GetComponent<ItemData>().interactible)
            {
                pickupText.text = "Press E to pick up\n" + col.transform.GetComponent<ItemData>().itemInfo.objectLongName;
                thisItem = col;
                inRange = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        pickupText.text = "";
        inRange = false;
    }
}
