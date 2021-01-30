using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> itemInInventory;
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
    }

    IEnumerator DecreaseOne()
    {
        yield return new WaitForSeconds(timeToDecrease);
        sanityPoint--;
        isCounting = false;
    }
}
