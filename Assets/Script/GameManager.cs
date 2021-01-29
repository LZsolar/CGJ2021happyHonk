using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
   // public GameObject TMH;
    [SerializeField] private int timeLeft = 300;
    public TextMeshProUGUI Timer;
    private bool decresing = false;

    void Start()
    {
        //Timer=GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0&&!decresing) {
            StartCoroutine(CountDown());
        }
    }

    IEnumerator CountDown() {
        decresing = true;
        yield return new WaitForSeconds(1);
        timeLeft -= 1;
        if (timeLeft >= 250) {Timer.SetText( "04:{0}" , timeLeft-240); }
        else if (timeLeft >= 240) { Timer.SetText("04:0{0}", timeLeft - 240); }
        else if (timeLeft >= 190) { Timer.SetText("03:{0}", timeLeft - 180); }
        else if (timeLeft >= 180) { Timer.SetText("03:0{0}", timeLeft - 180); }
        else if (timeLeft >= 130) { Timer.SetText("02:{0}", timeLeft - 120); }
        else if (timeLeft >= 120) { Timer.SetText("02:0{0}", timeLeft - 120); }
        else if (timeLeft >= 70) { Timer.SetText("01:{0}", timeLeft - 60); }
        else if (timeLeft >= 60) { Timer.SetText("01:0{0}", timeLeft - 60); }
        else if (timeLeft >= 10) { Timer.SetText("00:{0}", timeLeft); }
        else { Timer.SetText("00:0{0}", timeLeft); }



        decresing = false;
    }
}
