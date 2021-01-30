using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneMenu : MonoBehaviour
{
    public Player PlayerScp;
    public GameObject phone,PageInfo,PageNote,PageSetting;
    public Button Info,Note,Setting;
    public GameObject Nitem1;
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
            Info.Select();
            ActivePhone = true;
            PlayerScp.speed = 0;
        }

        else if (Input.GetKeyDown(KeyCode.X) && ActivePhone && !ActivePage)
        {
            phone.SetActive(false);
            ActivePhone = false;
            PlayerScp.speed = 5;
        }
        else if(Input.GetKeyDown(KeyCode.X)) {
            phone.SetActive(true);
            ActivePage = false;
            PageInfo.SetActive(false);
            PageNote.SetActive(false);
            PageSetting.SetActive(false);
        }


        if (PlayerScp.Fitem1) {
            Nitem1.SetActive(true);
        }
    }

    public void InfoOpen()
    {
        PageInfo.SetActive(true);
        phone.SetActive(false);
        ActivePage = true;
    }
    public void NoteOpen()
    {
        PageNote.SetActive(true);
        phone.SetActive(false);
        ActivePage = true;
    }
    public void SettingOpen()
    {
        PageSetting.SetActive(true);
        phone.SetActive(false);
        ActivePage = true;
    }
}
