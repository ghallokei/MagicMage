using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Story1()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void Story2()
    {
        page2.SetActive(false);
        Time.timeScale = 1;
    }

}
