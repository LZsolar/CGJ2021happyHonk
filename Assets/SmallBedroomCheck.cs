using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBedroomCheck : MonoBehaviour, IRoomCheck
{
    public GameObject itemToShow;
    public List<Item> bedroomRecipe;
    public List<Item> currentZone;
    public void RemoveFromCurrent(Item item)
    {
        currentZone.Remove(item);
    }
    public void AddToCurrent(Item item)
    {
        currentZone.Add(item);
    }

    public void InitiateCheck()
    {

    }
}
