using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shirenhua : MonoBehaviour
{

     //血量
    public int hp = 1;

    private bool attack = false;

    //动画控制器
    private Animator ani;

    private float timer = 0;

    //判断玩家距离
    private Player player;

    public GameObject attackPre;
    public Transform attackpos;

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
                  ani.SetTrigger("die");
                                    Destroy(GetComponent<Rigidbody2D>());
                                    Destroy(GetComponent<CapsuleCollider2D>());
                                    Destroy(gameObject,1f);
            }
            timer += Time.deltaTime;
            if(attack == true){
                 if(timer > 1){
                            
                            
                            ani.SetBool("isattack",true);
                            Instantiate(attackPre,attackpos.position,attackpos.rotation);
                            timer = 0;
                        }
            }





    }


     private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "Player"){

                attack = true;
                
            }
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
