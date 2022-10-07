using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfoot : MonoBehaviour
{

    public Player Player;
    private paotai paotai;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").GetComponent<Player>();
          paotai = GameObject.FindWithTag("paotai").GetComponent<paotai>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.S)  && paotai.transform.position.x - Player.transform.position.x < 3 && paotai.transform.position.x - Player.transform.position.x   > -3  ){
                         
                        
                        Destroy(gameObject);
                        
                }
          if(Player.hp <= 0){

                        
                        Destroy(GetComponent<Rigidbody2D>());
                        Destroy(GetComponent<CapsuleCollider2D>());
                    
                        Destroy(gameObject ,1f);
                        
                
                    }

    }
}
