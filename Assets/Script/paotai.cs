using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paotai : MonoBehaviour
{


        Sprite sprite ;
        //判断玩家距离
        private Player player;
    // Start is called before the first frame update
    void Start()
    {
         Sprite sprite = Resources.Load<Sprite>("image2014");
         player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.ispaotai){
             changeImg();

        }
    }


    public void changeImg(){
        //水平轴移动 -1 0 1
        float horizontal = Input.GetAxis("Horizontal");
        
            
              switch ((int)(horizontal / 0.125)){
                    case 0 :
                         sprite = Resources.Load<Sprite>("image2014");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 1 : case -1:
                         sprite = Resources.Load<Sprite>("image2016");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 2 : case -2:
                         sprite = Resources.Load<Sprite>("image2018");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 3 : case -3:
                         sprite = Resources.Load<Sprite>("image2020");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 4 : case -4:
                         sprite = Resources.Load<Sprite>("image2022");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 5 : case -5:
                         sprite = Resources.Load<Sprite>("image2024");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 6  : case -6:
                         sprite = Resources.Load<Sprite>("image2026");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 7 : case -7:
                        sprite = Resources.Load<Sprite>("image2028");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    case 8 : case -8:
                         sprite = Resources.Load<Sprite>("image2030");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(horizontal>0 ? 5: -5, 5, 1);
                         break;
                    
              }

              
        
    }
}
