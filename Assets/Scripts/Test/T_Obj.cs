using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Obj : MonoBehaviour
{
    public float Speed;
    public GameObject T_object;

    void Update()
    {
        if (Speed <= 8.5)
            Speed += Time.deltaTime * 1f;
        this.transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));



    }
}
