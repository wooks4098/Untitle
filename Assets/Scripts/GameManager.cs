using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Speed = 2; //이동하는 오브젝트 속도
    private static GameManager instance = null;

    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    void Update()
    {
        
    }
    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public void Object_Move(GameObject obj)//오브젝트 이동(캐릭터, 카메라)
    {
        obj.transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
    }

    
}
