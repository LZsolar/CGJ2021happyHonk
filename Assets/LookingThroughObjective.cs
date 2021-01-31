using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LookingThroughObjective : MonoBehaviour
{
    public List<Item> objItem;
    public List<bool> checkFinished;
    public int finishedCount = 0;
    private int currPage = 0;
    public GameObject tutorialPage, mainPage;
    public TextMeshProUGUI combineName, combineLoc, stateText;
    public Image _renderer;
    public GameObject leftStuff, rightStuff;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currPage--;
            currPage = Mathf.Clamp(currPage, 0, objItem.Count);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currPage++;
            currPage = Mathf.Clamp(currPage, 0, objItem.Count);
        }
        if(currPage == 0)
        {
            tutorialPage.SetActive(true);
            mainPage.SetActive(false);
            leftStuff.SetActive(false);
            rightStuff.SetActive(true);
        }
        else
        {
            leftStuff.SetActive(true);
            if(currPage == objItem.Count)
                rightStuff.SetActive(false);
            else
                rightStuff.SetActive(true);
            tutorialPage.SetActive(false);
            mainPage.SetActive(true);
            Item thisItem = objItem[currPage-1];
            _renderer.sprite = thisItem.sprite;
            combineName.text = thisItem.objectName;
            combineLoc.text = thisItem.roomLocation;
            if(!checkFinished[currPage-1])
                stateText.text = "UNFINISHED";
            else
                stateText.text = "FINISHED";
        }
    }
}
