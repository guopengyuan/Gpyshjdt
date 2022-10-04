using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy1 : MonoBehaviour
{

    //血量
    public int hp = 1;

    //动画控制器
    private Animator ani;

    private float timer = 0;

    //判断玩家距离
    private Player player;
    //子弹预设体
    public GameObject BulletPre;
    //开火点
    public Transform FirePoint;

   

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
                                    Destroy(gameObject,1.5f);
                                    ani.SetTrigger("die");
        }

        
        if(transform.position.x - player.transform.position.x > 0){
                transform.localScale = new Vector3(5,5,1);
        }
        else {
                transform.localScale = new Vector3(-5,5,1);
        }
        
        float dis = Vector3.Distance(player.transform.position,transform.position);
        timer += Time.deltaTime;

        if(dis < 10){
            if(timer > 1){
                            
                            ani.SetBool("isrun",false);
                            ani.SetBool("isattack",true);
                             Instantiate(BulletPre,FirePoint.position,FirePoint.rotation).GetComponent<bullet>().dir = transform.localScale.x * -1;
                            timer = 0;
                        }
        }
        else if(dis > 10 && dis < 20){
            
            
                ani.SetBool("isattack",false);
                ani.SetBool("isrun",true);
                transform.Translate((transform.position.x - player.transform.position.x > 0 ?Vector2.left : Vector2.right)  * 2f * Time.deltaTime);
            
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
