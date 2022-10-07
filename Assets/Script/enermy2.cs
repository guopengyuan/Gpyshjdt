using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy2 : MonoBehaviour
{

         //血量
        public int hp = 1;

        //动画控制器
        private Animator ani;

        private float timer = 0;

        //判断玩家距离
        private Player player;
        


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();

        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
         if(hp <= 0){
                                    Destroy(GetComponent<Rigidbody2D>());
                                    Destroy(GetComponent<CapsuleCollider2D>());
                                    Destroy(gameObject);
                                    //ani.SetTrigger("die");
        }

        float dis = Vector3.Distance(player.transform.position,transform.position);
        timer += Time.deltaTime;

        if(dis < 15){
                  
                transform.Translate(Vector2.left * 7f * Time.deltaTime );

            
                     
        }
        
            
    }

 //如果碰到子弹
     private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "bullet"){
                hp--;
                
            }
            if(collision.collider.tag == "nearattack"  ){
                hp--;
                
            }

             if(collision.collider.tag == "shoulei"  ){
                hp--;
                
            }
     }


}


   
   
