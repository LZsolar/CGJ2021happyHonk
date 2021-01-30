using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInteraction : MonoBehaviour
{
    public Inventory inventory;
    public TextMeshProUGUI pickupText;

    void Start()
    {
        pickupText.text = "";
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.GetComponent<ItemData>().itemInfo.type == itemType.Pickable)
            pickupText.text = "Press E to pick up\n" + col.transform.GetComponent<ItemData>().itemInfo.objectLongName;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(Input.GetKeyDown(KeyCode.E) && col.GetComponent<ItemData>().itemInfo.type == itemType.Pickable)
        {
            inventory.itemInInventory.Add(col.transform.GetComponent<ItemData>().itemInfo);
            inventory.itemReference.Add(col);
            col.transform.position = new Vector3(-100f, -100f, 0f);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        pickupText.text = "";
    }
}
