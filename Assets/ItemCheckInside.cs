using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheckInside : MonoBehaviour
{
    private ItemData data;
    void Start()
    {
        data = GetComponent<ItemData>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Check"))
        {
            col.GetComponent<IRoomCheck>().AddToCurrent(data.itemInfo);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Check"))
        {
            col.GetComponent<IRoomCheck>().RemoveFromCurrent(data.itemInfo);
        }
    }
}
