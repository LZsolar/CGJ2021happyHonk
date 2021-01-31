using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManage : MonoBehaviour
{
    public Inventory inventory;
    public LookingThroughObjective objective;
    public Transform player, ghost;
    bool startEnding = false;
    void Update()
    {
        if(!startEnding)
        {
            //insanity end
            if(inventory.sanityPoint <= 0f)
            {
                Debug.Log("INSANE");
                startEnding = true;
                Time.timeScale = 0f;
            }
            //good end
            else if(objective.finishedCount == 3)
            {
                Debug.Log("GOOD");
                startEnding = true;
                Time.timeScale = 0f;
            }
            else if(Vector3.Distance(player.position, ghost.position) <= 0.5f)
            {
                ForceDeadEnd();
            }
        }
    }
    
    public void ForceDeadEnd()
    {
         Debug.Log("DEAD");
        startEnding = true;
        Time.timeScale = 0f;
    }
}
