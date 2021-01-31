using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Inventory : MonoBehaviour
{
    public Light2D playerLight;
    public List<Item> itemInInventory;
    public List<Collider2D> itemReference;
    public float sanityPoint = 100f;
    public float timeToDecrease;
    bool isCounting = false;

    void Update()
    {
        if(!isCounting)
        {
            isCounting = true;
            StartCoroutine(DecreaseOne());
        }
        playerLight.pointLightOuterRadius = Mathf.Lerp(2f, 15f, 1f - ((100f - sanityPoint)/100f));
    }

    IEnumerator DecreaseOne()
    {
        yield return new WaitForSeconds(timeToDecrease);
        sanityPoint--;
        isCounting = false;
    }
}
