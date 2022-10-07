using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{

    private bool iffree = false;
    private bool ifrun  = false;
    private bool ifgive  = false;
    private bool ifaway  = false;

    //判断玩家距离
    private Player player;
    private Animator ani;

    public GameObject winPre;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(iffree){
                ani.SetTrigger("free");
                
        }

        if(ifrun){
                iffree = false;
                ani.SetTrigger("run");
                if(!ifgive){
                     transform.Translate( Vector2.left  * 5f * Time.deltaTime);
                }
               
                
        }
        if(ifgive){
                ifrun = false;
                ani.SetTrigger("give");
                //扔下道具

                Instantiate(winPre,transform.position,transform.rotation);
                Destroy(GetComponent<Rigidbody2D>());
                Destroy(GetComponent<BoxCollider2D>());
                ifgive = false;
                
        }

        if(ifaway){
                ifgive = false;
                ani.SetTrigger("away");
                transform.Translate( Vector2.left  * 5f * Time.deltaTime);
                
        }
        if(player.transform.position.x - transform.position.x > 15){
                    Destroy(gameObject);
            }



    }

    private void  OnCollisionEnter2D(Collision2D collision) {
    if(collision.collider.tag == "bullet"){
                iffree = true;
                
    }
    if(collision.collider.tag == "nearattack"  ){
                 iffree = true;
                
    }

     if(collision.collider.tag == "shoulei"  ){
                iffree = true;
                
     }

     if(collision.collider.tag == "Player"  ){
                ifgive = true;
                
     }

    }


    public void Run(){
        ifrun = true;
    }

    public void Away(){
        ifaway = true;
    }

}
