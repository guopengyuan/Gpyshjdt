using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update


      //动画控制器
    private Animator ani;

    //刚体
    private Rigidbody2D rbody;

    public Transform head;

    //是否踩在地面上
    private bool isGrond = true;

   

    public int hp = 10;

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
            //转身
                transform.localScale = new Vector3(horizontal>0 ? 0.5f: -0.5f, 1, 1);

            //移动
                transform.Translate(Vector2.right * horizontal * 5 * Time.deltaTime);
                if(Input.GetKeyDown(KeyCode.Space) && isGrond == true){
                        rbody.AddForce(Vector2.up * 750);
                }

        }else {

        }
        if(hp <= 0){
                    head.GetComponent<Animator>().SetTrigger("die");
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                   
                    Destroy(gameObject ,1f);
                    
            
                }
      


      

    }

      //碰撞到地面
        private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "Grond"){
                isGrond = true;
            }
            if(collision.collider.tag == "bullet"){
                hp--;
                
            }
            if(collision.collider.tag == "shoulei"){
                hp--;
                
            }
            if(collision.collider.tag == "enermy2"){
                hp-=10;
                
            }
            if(collision.collider.tag == "dilei"){
                hp-=10;
                
            }
             if(collision.collider.tag == "zhadan"){
                hp--;
                
            }
            if(collision.collider.tag == "hp"){
                hp++;
                
            }
            
            

        }

        //离开地面
        void OnCollisionExit2D(Collision2D collision) {
            if(collision.collider.tag == "Grond"){
                isGrond = false;
            }
        }
    
}

