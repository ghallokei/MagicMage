using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    private Vector3 camraOffSet;
    
    public float smoothing = 2;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        camraOffSet = transform.position - player.transform.position;
    }
    void Update()
    {
        Vector3 newPos= player.position + camraOffSet;
        //transform.position = Vector3.Lerp(transform.position, newPos, smoothing * Time.deltaTime);
        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothing);

    }
}
