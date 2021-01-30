using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class FaceChanging : MonoBehaviour
{
    private Animator DollAnimation;
    public AIPath aiPath;

    void Start()
    {
        DollAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        DollAnimation.SetFloat("XPos", aiPath.desiredVelocity.x);
        DollAnimation.SetFloat("YPos", aiPath.desiredVelocity.y);
    }
}
