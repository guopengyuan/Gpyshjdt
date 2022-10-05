using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

    private int  move;
    private bool moveright;
     //判断玩家距离
    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        if(player.ispaotai){
            transform.Translate(transform.right * move * 10* Time.deltaTime); 
            if(Input.GetKeyDown(KeyCode.K)){
            move = -1;
            }
            if(Input.GetKeyDown(KeyCode.L)){
            move = 1;      
            }
        
            
        }
        
        
        
         
    }
}
