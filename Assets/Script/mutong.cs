using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutong : MonoBehaviour
{

    public int hp = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeimage();
        if(hp <= 0){
             Destroy(GetComponent<Rigidbody2D>());
             Destroy(GetComponent<BoxCollider2D>());
        }
    }


      private void  OnCollisionEnter2D(Collision2D collision) {
            
            if(collision.collider.tag == "bullet"){
                hp--;
                
            }
            if(collision.collider.tag == "shoulei"){
                hp--;
                
            }
            if(collision.collider.tag == "nearattack"  ){
                hp--;
                
            }
            if(collision.collider.tag == "pao"  ){
                hp--;
                
            }
            
            
        }



        public void changeimage(){
            

            if(hp == 2){
                    Sprite sprite = Resources.Load<Sprite>("image360");
                    
                    transform.GetComponent<SpriteRenderer>().sprite = sprite;
                    
            }else if(hp == 1){
                   Sprite sprite = Resources.Load<Sprite>("image362");
                    
                    transform.GetComponent<SpriteRenderer>().sprite = sprite;

            }else if(hp == 0){
                      Sprite sprite = Resources.Load<Sprite>("image373");
                    
                    transform.GetComponent<SpriteRenderer>().sprite = sprite;
            }
        }
}
