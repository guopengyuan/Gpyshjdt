using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy3 : MonoBehaviour
{

    //血量
    public int hp = 1;

    //动画控制器
    private Animator ani;

    private float timer = 0;

    //判断玩家距离
    private Player player;
    //子弹预设体
    public GameObject paoPre;
    //开火点
    public Transform FirePoint;

    private  paotai paotai;
    // Start is called before the first frame update
    void Start()
    {
         ani = GetComponent<Animator>();

        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        paotai = GameObject.FindWithTag("paotai").GetComponent<paotai>();
    }

    // Update is called once per frame
    void Update()
    {
         if(hp <= 0){
                                    ani.SetTrigger("die");
                                    Destroy(GetComponent<Rigidbody2D>());
                                    Destroy(GetComponent<CapsuleCollider2D>());
                                    Destroy(gameObject,1.5f);
                                    
        }

        
        if(transform.position.x - player.transform.position.x > 0){
                transform.localScale = new Vector3(3,3,1);
        }
        else {
                transform.localScale = new Vector3(-3,3,1);
        }
        
        float dis = Vector3.Distance(player.transform.position,transform.position);
        timer += Time.deltaTime;

        if(dis < 20){
            if(timer > 1){
                            
                         Instantiate(paoPre,FirePoint.position,FirePoint.rotation).GetComponent<pao>().dir = new Vector2((transform.position.x - player.transform.position.x) * -1 / 10, (transform.position.y - player.transform.position.y) * -1 / 10);
                            timer = 0;
                        }
        }
        if( dis < 30){
            
                if(transform.position.y > player.transform.position.y)
                transform.Translate(transform.up   * -2f * Time.deltaTime);
            
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
            if(collision.collider.tag == "pao"  ){
                hp--;
                
            }


        }
}
