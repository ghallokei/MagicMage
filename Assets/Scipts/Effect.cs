using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartingRoutine());
    }

    IEnumerator StartingRoutine()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
