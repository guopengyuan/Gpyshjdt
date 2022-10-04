using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    //动画控制器
    private Animator ani;

    //刚体
    private Rigidbody2D rbody;

    //是否踩在地面上
    private bool isGrond;



    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //水平轴移动 -1 0 1
        float horizontal = Input.GetAxis("Horizontal");
        if(horizontal != 0){
                transform.localScale = new Vector3(horizontal>0? -1:1,1);
        }else {

        }

    }
}
