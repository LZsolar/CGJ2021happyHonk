using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class GhostBehavior : MonoBehaviour
{
    public AIPath aiPath;
    public AIDestinationSetter destinationSetter;
    public Animator DollAnimation;
    public LayerMask obstacleMask;
    public Transform positionNow;
    public Transform playerPosition;
    public GhostState stateNow = GhostState.Idle;
    public GhostState stateLast;
    public List<Transform> patrolLocation;
    public float TimePatrol;
    public float rangeSense;
    float idleTimer = 0f;
    int idxLast, idxNow;

    void Update()
    {
        if(stateNow == GhostState.Idle)
        {
            idleTimer += Time.deltaTime;
        }
        RaycastHit2D hit = Physics2D.Linecast(transform.position, playerPosition.position, obstacleMask);
        //see player
        if(hit.transform.gameObject.layer == 9 && Vector3.Distance(transform.position, playerPosition.position) <= rangeSense)
        {
            //if not chase
            if(stateNow != GhostState.Chase)
            {
                //start chasing
                stateLast = stateNow;
                stateNow = GhostState.Chase;
                positionNow.position = playerPosition.position;
                idleTimer = 0f;
            }
            //else keep on chasing
            else
            {
                positionNow.position = playerPosition.position;
            }
        }
        //not see player
        else
        {
            //lose sight of player
            if(stateNow == GhostState.Chase)
            {
                stateLast = stateNow;
                stateNow = GhostState.SearchLastLocation;
            }
            else if(stateNow == GhostState.Idle && idleTimer > TimePatrol)
            {
                idxLast = idxNow;
                while(idxNow == idxLast)
                    idxNow = Random.Range(0, patrolLocation.Count);
                Transform itemNow = patrolLocation[idxNow];
                Vector3 pNow = itemNow.position;
                pNow.z = 0f;
                positionNow.position = pNow;
                stateLast = stateNow;
                stateNow = GhostState.Patrol;
            }
        }
        //successfully reach last known location without seeing player again
        if(aiPath.reachedDestination && stateNow == GhostState.SearchLastLocation)
        {
            stateLast = stateNow;
            stateNow = GhostState.Idle;
            positionNow.position = new Vector3(-100, -100, 0f);
            idleTimer = 0f;
        }
        //successfully reach patrol location
        else if(aiPath.reachedDestination && stateNow == GhostState.Patrol)
        {
            stateLast = stateNow;
            stateNow = GhostState.Idle;
            positionNow.position = new Vector3(-100, -100, 0f);
            idleTimer = 0f;
        }
        BehaviorApply();
    }

    void BehaviorApply()
    {
        if(stateNow == GhostState.Idle)
        {
            aiPath.canMove = false;
            DollAnimation.SetBool("isChasing",false);
        }
        if(stateNow == GhostState.Chase)
        {
            aiPath.canMove = true;
            DollAnimation.SetBool("isChasing",true);
        }
        if(stateNow == GhostState.SearchLastLocation)
        {
            aiPath.canMove = true;
            DollAnimation.SetBool("isChasing",true);
        }
        if(stateNow == GhostState.Patrol)
        {
            aiPath.canMove = true;
            DollAnimation.SetBool("isChasing",true);
        }
    }
}

public enum GhostState
{
    Idle,
    Patrol,
    Defeated,
    Chase,
    SearchLastLocation
}
