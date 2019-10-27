using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{

    //public Text invertoryText;
    public static Inventory instance;
    private List<Page> papers = new List<Page>();

    public Text pagesCollected;

    private float timeLeft = 180;
    public Text timer;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddItem(Page item)
    {
        papers.Add(item);
    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = " " + Mathf.Round(timeLeft);
        
        pagesCollected.text = "Pages: " + papers.Count + "/10";
        
       /* string output = " ";
        papers.ForEach((item) =>
        {
            output += " - " + item.pageNumber + "\n";
        });
        invertoryText.text = output;*/

       if (papers.Count == 10)
       {
           SceneManager.LoadScene("WinScene");
       }

       if (timeLeft <= 0 && papers.Count < 10)
       {
           SceneManager.LoadScene("GameOverScene");
       }
    }
}
