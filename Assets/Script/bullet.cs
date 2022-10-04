using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{



    //方向
    public float dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * 15 * Time.deltaTime * (dir > 0 ?1 : -1));
    }




      private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "enermy"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }


            if(collision.collider.tag == "Player"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }

            if(collision.collider.tag == "bullet"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }

            if(collision.collider.tag == "mutong"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
                if(collision.collider.tag == "enermy2"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
                if(collision.collider.tag == "npc"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
            
      }
}
