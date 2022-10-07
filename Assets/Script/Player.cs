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

    private GameObject head;

    //是否踩在地面上
    private bool isGrond = true;
    public bool ispaotai = false;
    private paotai paotai;

    public GameObject paotaiplayer;
    public GameObject headPre;
    public GameObject footPre;
    Sprite sprite ;
    private int move;
    public bool win;
   

    public int hp = 10;

    void Start()
    {
        
         ani = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
        paotai = GameObject.FindWithTag("paotai").GetComponent<paotai>();
    }

    // Update is called once per frame
    void Update()
    {

        if(!ispaotai){
         //水平轴移动 -1 0 1
        float horizontal = Input.GetAxis("Horizontal");

        
                if(horizontal != 0){
                //转身
                    transform.localScale = new Vector3(horizontal>0 ? 1: -1, 1, 1);

                //移动
                    transform.Translate(Vector2.right * horizontal * 5 * Time.deltaTime);
                    

                }else {

                }
                
                if(Input.GetKeyDown(KeyCode.Space) && isGrond == true){
                            rbody.AddForce(Vector2.up * 750);
                    }
                

        }
        if(transform.position.x - paotai.transform.position.x > -3  &&  Input.GetKeyDown(KeyCode.S) && transform.position.x - paotai.transform.position.x < 3 && !ispaotai){
                                        Instantiate(paotaiplayer,paotai.transform.position,paotai.transform.rotation ,transform);
                                        //碰撞体和刚体未销毁
                                        
                                        ispaotai = true;
                                    
             }

        if(ispaotai){
            if(Input.GetKeyDown(KeyCode.Space)){
                Instantiate(headPre,transform.position + new Vector3(0,-0.75f,0),transform.rotation,transform);
                head = Instantiate(footPre,transform.position+ new Vector3(0,-2,0) ,transform.rotation,transform);
                ispaotai = false;

            }

            
            
            if(Input.GetKeyDown(KeyCode.K)){
                if(move == 1){
                    move = 0;
                }
                move = -1;
            }
            if(Input.GetKeyDown(KeyCode.L)){
                if(move == -1){
                    move = 0;
                }
            move = 1;      
            }

            transform.Translate(transform.right * move * 10* Time.deltaTime); 


            transform.position = paotai.transform.position;
        }


    }

      //碰撞到地面
        private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "Grond" || collision.collider.tag == "mutong" || collision.collider.tag == "car"){
                isGrond = true;
            }
            if(collision.collider.tag == "car"){
                isGrond = true;
            }

            if(collision.collider.tag == "bullet"){
                hp--;
                
            }
            if(collision.collider.tag == "shoulei"){
                hp--;
                
            }
            if(collision.collider.tag == "enermy2"){
                hp--;
                
            }
            if(collision.collider.tag == "dilei"){
                hp--;
                
            }
             if(collision.collider.tag == "zhadan"){
                hp--;
                
            }
            if(collision.collider.tag == "pao"){
                hp--;
                
            }
            if(collision.collider.tag == "hp"){
                hp++;

                
                
            }
            if(collision.collider.tag == "win"){
                

                win = true;
                
            }
            if(collision.collider.tag == "nearattack"){
                hp--;
                
            }
            
            

        }

        //离开地面
        private void OnCollisionExit2D(Collision2D collision) {
            if(collision.collider.tag == "Grond"){
                isGrond = false;
            }
        }


        
    
}

