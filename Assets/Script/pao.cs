using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pao : MonoBehaviour
{

    public Vector2 dir ;
    // Start is called before the first frame update
    void Start()
    {


        //修改旋转体参数
        transform.localEulerAngles = new Vector3(0,0,0);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( transform.right * dir.x *8 * Time.deltaTime);
        transform.Translate( transform.up * dir.y * 8 * Time.deltaTime );
    }

     private void  OnCollisionEnter2D(Collision2D collision) {
            if(collision.collider.tag == "enermy"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
            if(collision.collider.tag == "mutong"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
            if(collision.collider.tag == "Player"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
            if(collision.collider.tag == "enermy3"){
                
                
                    Destroy(GetComponent<Rigidbody2D>());
                    Destroy(GetComponent<CapsuleCollider2D>());
                    Destroy(gameObject);
                    
                }
            


            
      }
}
