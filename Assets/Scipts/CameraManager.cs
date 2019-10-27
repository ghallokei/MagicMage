using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public List<Camera> gameCams;

    private void OnTriggerEnter(Collider other)
    {
        if (gameCams[0].enabled)
        {
            gameCams[1].enabled = true;
            gameCams[0].enabled = false;
        }
        else {
            
            gameCams[1].enabled = false;
            gameCams[0].enabled = true;
        }
    }
}
