using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float JumpScale;
    Rigidbody2D rigid;
    

    private void Awake()
    {
       
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        GameManager.Instance.Object_Move(gameObject);
        Jump();
        

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !Input.GetKey(KeyCode.DownArrow))
            rigid.AddForce(Vector2.up * JumpScale, ForceMode2D.Impulse);
    }
}
