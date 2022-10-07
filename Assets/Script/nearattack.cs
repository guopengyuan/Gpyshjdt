using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearattack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "enermy" || collision.collider.tag == "Player"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }


            
      }
}
