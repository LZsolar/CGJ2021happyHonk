using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button stt;
    public GameObject Cradit;

    // Start is called before the first frame update
    void Start()
    {
        stt.Select();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) {
            Cradit.SetActive(false);
        }
    }

    public void CraditOpen()
    {
        Cradit.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void qquit()
    {
        Application.Quit();
    }
}
