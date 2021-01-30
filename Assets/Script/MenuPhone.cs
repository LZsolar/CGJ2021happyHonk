using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPhone : MonoBehaviour
{
    public GameObject phone,PageMain, PageInfo, PageNote, PageSetting;
    public Button Info, Note, Setting;
    private bool ActivePhone, ActivePage;
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
            phone.SetActive(true);
            PageMain.SetActive(true);
            Info.Select();
            ActivePhone = true;
        }

        else if (Input.GetKeyDown(KeyCode.X) && ActivePhone && !ActivePage)
        {
            phone.SetActive(false);
            PageMain.SetActive(false);
            ActivePhone = false;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            PageMain.SetActive(true);

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
    }
    public void NoteOpen()
    {
        PageMain.SetActive(false);
        PageNote.SetActive(true);
        ActivePage = true;
    }
    public void SettingOpen()
    {
        PageMain.SetActive(false);
        PageSetting.SetActive(true);
        ActivePage = true;
    }
}
