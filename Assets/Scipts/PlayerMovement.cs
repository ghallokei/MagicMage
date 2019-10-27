using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4.0f;
    public float clockwise = 1000.0f;
    public float counterClockwise = -5.0f;
    void Update(){
        
 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(movementSpeed * Time.deltaTime * Vector3.forward);
        }
 
        if (Input.GetKey(KeyCode.E)){
            transform.Rotate(0, Time.deltaTime * clockwise, 0);
        }
 
        if (Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
        }
    }
}
