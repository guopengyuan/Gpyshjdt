using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toudanji : MonoBehaviour
{


     //判断玩家距离
    private Player player;
    //炸弹预设体
    public GameObject zhadanPre;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - player.transform.position.x < 10){
              Instantiate(zhadanPre,transform.position,transform.rotation);
              Instantiate(zhadanPre,transform.position - new Vector3(5,0,0),transform.rotation);
              Instantiate(zhadanPre,transform.position + new Vector3(5,0,0),transform.rotation);
              Destroy(gameObject);
        }
    }
}
