using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilei : MonoBehaviour
{


     private Animator ani;
     private bool ifboom = false;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ifboom == true){
                 ani.SetTrigger("boom");
            
                Destroy(GetComponent<Rigidbody2D>());
                Destroy(GetComponent<CapsuleCollider2D>());
                Destroy(gameObject,1.5f);
        }
    }


      private void  OnCollisionEnter2D(Collision2D collision) {
            
            if(collision.collider.tag == "bullet"){
                ifboom = true;
                
            }
            if(collision.collider.tag == "shoulei"){
                ifboom = true;
                
            }
            if(collision.collider.tag == "nearattack"  ){
                ifboom = true;
                
            }
            if(collision.collider.tag == "Player"  ){
                ifboom = true;
                
            }
            
            
        }
}
