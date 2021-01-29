using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class PhoneMenu : MonoBehaviour
{
    public Player Playercanmove;
    public GameObject phone,PageInfo,PageNote,PageSetting;
    public Button Info,Note,Setting;

    private bool ActivePhone,ActivePage;
    // Start is called before the first frame update
    void Start()
    {
        phone.SetActive(false);
        ActivePhone = false;
        ActivePage = false;
        PageInfo.SetActive(false);
        PageNote.SetActive(false);
        PageSetting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && !ActivePhone)
        {
            phone.SetActive(true);
            ActivePhone = true;
            Playercanmove.speed = 0;
            Info.Select();
        }

        else if (Input.GetKeyDown(KeyCode.X) && ActivePhone && !ActivePage)
        {
            phone.SetActive(false);
            ActivePhone = false;
            Playercanmove.speed = 5;
        }
        else if(Input.GetKeyDown(KeyCode.X)) {
            ActivePage = false;
            PageInfo.SetActive(false);
            PageNote.SetActive(false);
            PageSetting.SetActive(false);
        }

    }

    public void InfoOpen()
    {
        PageInfo.SetActive(true);
        ActivePage = true;
    }
    public void NoteOpen()
    {
        PageNote.SetActive(true);
        ActivePage = true;
    }
    public void SettingOpen()
    {
        PageSetting.SetActive(true);
        ActivePage = true;
    }
}
*/
