using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class MainMenu : MonoBehaviour
{
    public Button stt;
    public GameObject Cradit,OPpic,Canvass;
    private PlayableDirector pd;

    // Start is called before the first frame update
    void Start()
    {
        pd = GetComponent<PlayableDirector>();
        stt.Select();
        pd.Stop();
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
        Canvass.SetActive(false);
        OPpic.SetActive(true);
        pd.Play();
        StartCoroutine(waiting());
    }

    public void qquit()
    {
        Application.Quit();
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(18);
        SceneManager.LoadScene(1);
    }
}
