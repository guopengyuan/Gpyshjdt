using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paotaiplayer : MonoBehaviour
{
    public GameObject paoPre;
    public GameObject playerPre;
    private Player player;
    public Vector3 paoPoint;
    private paotai paotai;
    private rottemp rot;
    float horizontal;
    private int hp;
    
     Sprite sprite ;
     private int dir;
    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = Resources.Load<Sprite>("image2040");
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        paotai = GameObject.FindWithTag("paotai").GetComponent<paotai>();
        dir = (int )player.transform.localScale.x * 2;
        rot = GameObject.FindWithTag("rottemp").GetComponent<rottemp>();
    }

    // Update is called once per frame
    void Update()
    {
        changePlayer();
        if(Input.GetKeyDown(KeyCode.Space)){
            
            Destroy(gameObject);
        }

        if(Input.GetKeyDown(KeyCode.J)){
                    Instantiate(paoPre,paoPoint, rot.transform.rotation).GetComponent<pao>().dir = new Vector2( 5 * horizontal,horizontal > 0 ? (5 - 5 * horizontal) : (5 + 5 * horizontal)) ;
        }

        


        
    }



    public void changePlayer(){

            horizontal = Input.GetAxis("Horizontal");

            if(horizontal * player.transform.localScale.x > 0){
                dir = -10;
            }else{
                dir = 10;
            }

            paoPoint = paotai.transform.position + new Vector3( 5 * horizontal,horizontal > 0 ? (5 - 5 * horizontal) : (5 + 5 * horizontal),0);
            rot.transform.localEulerAngles = new Vector3(0,0,90 * (90 - horizontal) - 90);
            transform.position = paotai.transform.position;
            

            switch ((int)(horizontal / 0.125)){
                    case 0 :
                         sprite = Resources.Load<Sprite>("image2040");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 1 : case -1:
                         sprite = Resources.Load<Sprite>("image2042");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 2 : case -2:
                         sprite = Resources.Load<Sprite>("image2044");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 3 : case -3:
                         sprite = Resources.Load<Sprite>("image2046");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 4 : case -4:
                         sprite = Resources.Load<Sprite>("image2048");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 5 : case -5:
                         sprite = Resources.Load<Sprite>("image2050");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 6  : case -6:
                         sprite = Resources.Load<Sprite>("image2052");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 7 : case -7:
                        sprite = Resources.Load<Sprite>("image2054");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                          transform.localScale = new Vector3(dir  , 5, 1);
                         break;
                    case 8 : case -8:
                         sprite = Resources.Load<Sprite>("image2056");
                         transform.GetComponent<SpriteRenderer>().sprite = sprite;
                         transform.localScale = new Vector3(dir  , 5, 1);
                         break;
        }
        }





}
