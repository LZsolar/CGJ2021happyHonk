using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class GhostSpeed : MonoBehaviour
{
    public Inventory playerInventory;
    public AIPath aiPath;
    
    void Update()
    {
        if(playerInventory.sanityPoint <= 100f && playerInventory.sanityPoint >= 80f)
        {
            aiPath.maxSpeed = 0.8f;
        }
        else if(playerInventory.sanityPoint <= 79f && playerInventory.sanityPoint >= 40f)
        {
            aiPath.maxSpeed = 1.2f;
        }
        else if(playerInventory.sanityPoint <= 39f && playerInventory.sanityPoint >= 10f)
        {
            aiPath.maxSpeed = 2f;
        }
        else if(playerInventory.sanityPoint <= 9f)
        {
            aiPath.maxSpeed = 4f;
        }
        
    }
}
