using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform PlayFromCheck_Transform;//플랫폼 체크 위치
    public float PlatFormCheck_Distance;//플랫폼 체크 길이
    public LayerMask PlatFormCheck_Layer;//플랫폼 체크 레이어
    public float JumpScale; //점프 크기
    private bool isJump;//점프 가능한지 확인하는 변수 True면 가능

    Rigidbody2D rigid; //물리

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
        isJump = Physics2D.Raycast(PlayFromCheck_Transform.position, Vector2.down, PlatFormCheck_Distance, PlatFormCheck_Layer);
        Debug.DrawRay(PlayFromCheck_Transform.transform.position, Vector2.down * PlatFormCheck_Distance, Color.red, 1f);

        if (Input.GetKeyDown(KeyCode.Space) && !Input.GetKey(KeyCode.DownArrow) && isJump == true)
        {
            rigid.AddForce(Vector2.up * JumpScale, ForceMode2D.Impulse);
            isJump = false;
        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "PlatForm")
    //        isJump = true;
    //}
}
