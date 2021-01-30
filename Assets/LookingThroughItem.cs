using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LookingThroughItem : MonoBehaviour
{
    public Transform playerPos;
    public MenuPhone phoneStuff;
    public Inventory inventory;
    private int currPage = 0;
    public GameObject mainPage, instruction, description;
    public TextMeshProUGUI pickupName;
    public Image _renderer;
    public GameObject leftStuff, rightStuff;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currPage--;
            currPage = Mathf.Clamp(currPage, 0, inventory.itemInInventory.Count-1);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currPage++;
            currPage = Mathf.Clamp(currPage, 0, inventory.itemInInventory.Count-1);
        }
        if(currPage == 0)
        {
            leftStuff.SetActive(false);
        }
        else
        {
            leftStuff.SetActive(true);
        }
        if(currPage >= inventory.itemInInventory.Count-1)
            rightStuff.SetActive(false);
        else
            rightStuff.SetActive(true);
        mainPage.SetActive(true);
        if(inventory.itemInInventory.Count > 0)
        {
            _renderer.gameObject.SetActive(true);
            instruction.SetActive(true);
            description.SetActive(true);
            Item thisItem = inventory.itemInInventory[currPage];
            _renderer.sprite = thisItem.sprite;
            pickupName.text = thisItem.objectName;
        }
        else
        {
            instruction.SetActive(false);
            description.SetActive(false);
            _renderer.gameObject.SetActive(false);
            pickupName.text = "";
        }
        if(Input.GetKeyDown(KeyCode.Z) && phoneStuff.pageNow == CurrentPage.Item)
        {
            Item thisItem = inventory.itemInInventory[currPage];
            Collider2D thisStuff = inventory.itemReference[currPage];
            inventory.itemInInventory.RemoveAt(currPage);
            inventory.itemReference.RemoveAt(currPage);
            thisStuff.transform.position = playerPos.position;
        }
    }
}
