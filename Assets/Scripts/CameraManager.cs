using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
    void Update()
    {
        GameManager.Instance.Object_Move(gameObject);
    }
}
