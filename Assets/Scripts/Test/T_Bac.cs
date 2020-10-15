using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Bac : MonoBehaviour
{
    public MeshRenderer render;
    private float offset;
    public float Speed;
    private void Start()
    {
        Speed = 0;

    }
    private void Update()
    {
        if (Speed <= 0.2)
            Speed += Time.deltaTime * 0.02f;
        offset += Time.deltaTime * Speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
