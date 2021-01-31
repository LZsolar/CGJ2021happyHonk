using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButOnlyHowTo : MonoBehaviour
{
    private int page;

    public GameObject p1, p2, p3, p4, p5, p6;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)&&page<6) {
            page++;
            if (page == 2) {o1to2();}
            else if (page == 3) { o2to3(); }
            else if (page == 4) { o3to4(); }
            else if (page == 5) { o4to5(); }
            else if (page == 6) { o5to6(); }
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow) && page > 1)
        {
            page--;
            if (page == 5) { o6to5(); }
            else if (page == 4) { o5to4(); }
            else if (page == 3) { o4to3(); }
            else if (page == 2) { o3to2(); }
            else if (page == 1) { o2to1(); }
        }
    }

    public void o1to2() {
        p1.SetActive(false);
        p2.SetActive(true);
    }
    public void o2to3()
    {
        p2.SetActive(false);
        p3.SetActive(true);
    }
    public void o3to4()
    {
        p3.SetActive(false);
        p4.SetActive(true);
    }
    public void o4to5()
    {
        p4.SetActive(false);
        p5.SetActive(true);
    }
    public void o5to6()
    {
        p5.SetActive(false);
        p6.SetActive(true);
    }
    public void o2to1()
    {
        p1.SetActive(true);
        p2.SetActive(false);
    }

    public void o3to2()
    {
        p2.SetActive(true);
        p3.SetActive(false);
    }
    public void o4to3()
    {
        p3.SetActive(true);
        p4.SetActive(false);
    }
    public void o5to4()
    {
        p4.SetActive(true);
        p5.SetActive(false);
    }
    public void o6to5()
    {
        p5.SetActive(true);
        p6.SetActive(false);
    }

}
