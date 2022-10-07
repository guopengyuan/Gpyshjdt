using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xueliang : MonoBehaviour
{

    private Player player;
    Sprite sprite ;
    // Start is called before the first frame update
    void Start()
    {
         player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
         switch (player.hp){
                    case 0 :
                         sprite = Resources.Load<Sprite>("image1008");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         
                         break;
                    case 1 : 
                         sprite = Resources.Load<Sprite>("image1010");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          
                         break;
                    case 2 : 
                         sprite = Resources.Load<Sprite>("image1012");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         
                         break;
                    case 3 : 
                         sprite = Resources.Load<Sprite>("image1014");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         
                         break;
                    case 4 : 
                         sprite = Resources.Load<Sprite>("image1016");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         
                         break;
                    case 5 : 
                         sprite = Resources.Load<Sprite>("image1018");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         
                         break;
                    case 6  : 
                         sprite = Resources.Load<Sprite>("image1020");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                        
                         break;
                    case 7 : 
                        sprite = Resources.Load<Sprite>("image1022");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         
                         break;
                    case 8 : 
                         sprite = Resources.Load<Sprite>("image1024");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                        
                         break;
                    case 9 : 
                    sprite = Resources.Load<Sprite>("image1026");
                    transform.GetComponent<SpriteRenderer>().sprite = sprite;
                        
                         break;    
                 
        }
    }
}
