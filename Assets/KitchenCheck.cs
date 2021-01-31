using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCheck : MonoBehaviour, IRoomCheck
{
    public GameObject itemToShow;
    public List<Item> bedroomRecipe;
    public List<Item> currentZone;
    public LookingThroughObjective checkObj;
        bool finishedCheck = false;
    public bool isInside(Item item)
    {
        return bedroomRecipe.Contains(item);
    }
    public void RemoveFromCurrent(Item item)
    {
        currentZone.Remove(item);
    }
    public void AddToCurrent(Item item)
    {
        currentZone.Add(item);
    }
    void Update()
    {
        if(!finishedCheck)
        {   
            bool FinishedCollect = true;
            if(bedroomRecipe.Count > currentZone.Count)
            {
                FinishedCollect = false;
            }
            else
            {
                for(int i = 0;i<bedroomRecipe.Count;++i)
                {
                    if(!currentZone.Contains(bedroomRecipe[i]))
                    {
                        FinishedCollect = false;
                        break;
                    }
                }
            }
            if(FinishedCollect)
            {
                finishedCheck = true;
                itemToShow.SetActive(true);
                checkObj.checkFinished[1] = true;
            }
        }
    }
}
