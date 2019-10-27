
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindPages : MonoBehaviour
{
    public GameObject page;
    
    public GameObject hint;

    public ParticleSystem woosh;

    public AudioSource pageFlip;
    private void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.F) && hint.active)
        {
            if (page.name == "Page")
            {
                Text text = hint.GetComponent<Text>();
                text.text = "You found up page " + page.GetComponent<Page>().pageNumber + "!";
                StartCoroutine(feedBack());
                Inventory.instance.AddItem(page.GetComponent<Page>());
                Destroy(page);
                Vector3 location = new Vector3(page.GetComponent<Transform>().position.x, page.GetComponent<Transform>().position.y,page.GetComponent<Transform>().position.z);
                ParticleSystem effect = GameObject.Instantiate(woosh);
                effect.transform.position = location;
                pageFlip.Play();

            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Page"))
        {
            Text text = hint.GetComponent<Text>();
            text.text = "Press F to interact";
            hint.SetActive(true);
            page = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Page"))
        {
            Text text = hint.GetComponent<Text>();
            text.text = " ";
            hint.SetActive(false);
        }
    }

    IEnumerator feedBack()
    {
        yield return new WaitForSeconds(3);
        Text text = hint.GetComponent<Text>();
        text.text = "";
    }
}