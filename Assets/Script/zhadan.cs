using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhadan : MonoBehaviour
{


    private Animator ani;


    //是否在地面上
    private bool isGrond = false;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if(isGrond == true){
                ani.SetTrigger("boom");
                Destroy(gameObject,1f);
        }
    }

     //碰撞到地面
        private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "Grond"  || collision.collider.tag == "Player" ||collision.collider.tag == "bullet" || collision.collider.tag == "shoulei"){
                isGrond = true;
                
            }
        

        }

}
