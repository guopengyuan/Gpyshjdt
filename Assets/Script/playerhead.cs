using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhead : MonoBehaviour
{
    public Transform player;
    //子弹预设体
    public GameObject BulletPre;
    //开火点
    public Transform FirePoint;
    //开火计时器
    private float timer = 0;
    public GameObject AttPre;
    public Transform attackposition;
    public GameObject shoulei;
    private paotai paotai;
    private Player Player;

   


   //动画控制器
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
         ani = GetComponent<Animator>();

          Player = GameObject.FindWithTag("Player").GetComponent<Player>();
          player = Player.transform;
        
          paotai = GameObject.FindWithTag("paotai").GetComponent<paotai>();
          attackposition = GameObject.FindWithTag("playerposition").transform;
          FirePoint = GameObject.FindWithTag("playerposition").transform;
    }

    // Update is called once per frame
    void Update()
    {


        if(Player.hp <= 0){

                        ani.SetTrigger("die");
                        Destroy(GetComponent<Rigidbody2D>());
                        Destroy(GetComponent<CapsuleCollider2D>());
                    
                        Destroy(gameObject ,1f);
                        
                
                    }

         timer += Time.deltaTime;
          if(Input.GetKeyDown(KeyCode.J) && timer > 0.5f){
            timer = 0;
            ani.SetTrigger("attack");

            Instantiate(BulletPre,FirePoint.position,FirePoint.rotation).GetComponent<bullet>().dir = player.localScale.x * 1;
        }


        if(Input.GetKeyDown(KeyCode.K) && timer > 0.5f){
            timer = 0;
            ani.SetTrigger("nearatt");
            Instantiate(AttPre,attackposition.position,attackposition.rotation);
            
        }

        if(Input.GetKeyDown(KeyCode.L) && timer > 0.5f){
            timer = 0;
            ani.SetTrigger("toulei");
            
            Instantiate(shoulei,attackposition.position,attackposition.rotation).GetComponent<shoulei>().GetComponent<Rigidbody2D>().AddForce(new Vector3(1000 * player.localScale.x ,10,1000),ForceMode2D.Force);
        }


        if(Input.GetKeyDown(KeyCode.S)  && paotai.transform.position.x - Player.transform.position.x < 3 && paotai.transform.position.x - Player.transform.position.x   > -3  ){
                         
                        
                        Destroy(gameObject);
                        
                }
        
        
    }
}
