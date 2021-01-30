using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPhone : MonoBehaviour
{
    public GameObject phone,PageMain, PageInfo, PageNote, PageSetting;
    public Button Info, Note, Setting;
    private bool ActivePhone, ActivePage;
    public CurrentPage pageNow;
    // Start is called before the first frame update
    void Start()
    {
        phone.SetActive(false);
        PageMain.SetActive(false);
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
            Time.timeScale = 0f;
            phone.SetActive(true);
            PageMain.SetActive(true);
            Info.Select();
            ActivePhone = true;
        }

        else if (Input.GetKeyDown(KeyCode.X) && ActivePhone && !ActivePage)
        {
            Time.timeScale = 1f;
            phone.SetActive(false);
            PageMain.SetActive(false);
            ActivePhone = false;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            PageMain.SetActive(true);
            pageNow = CurrentPage.Main;
            ActivePage = false;
            PageInfo.SetActive(false);
            PageNote.SetActive(false);
            PageSetting.SetActive(false);
        }

    }

    public void InfoOpen()
    {
        PageMain.SetActive(false);
        PageInfo.SetActive(true);
        ActivePage = true;
        pageNow = CurrentPage.Info;
    }
    public void NoteOpen()
    {
        PageMain.SetActive(false);
        PageNote.SetActive(true);
        ActivePage = true;
        pageNow = CurrentPage.Item;
    }
    public void SettingOpen()
    {
        PageMain.SetActive(false);
        PageSetting.SetActive(true);
        ActivePage = true;
        pageNow = CurrentPage.Setting;
    }
}

public enum CurrentPage
{
    Main,
    Info,
    Item,
    Setting
}
