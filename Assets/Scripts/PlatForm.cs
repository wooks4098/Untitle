using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatForm : MonoBehaviour
{
    private PlatformEffector2D effector;
    float waitTime;

    private void Awake()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    private void Update()
    {
        waitTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.Space))//&& Input.GetKeyUp(KeyCode.Space)
        {
            
            effector.rotationalOffset = 180f;
            waitTime = 0;
        }


        if (waitTime >= 0.2)
        {
            effector.rotationalOffset = 0f;

        }
        
    }
}
