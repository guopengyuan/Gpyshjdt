using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

using UnityEngine.SceneManagement;


public class button : MonoBehaviour
{
    public GameObject text;
    public Canvas ui;

    private Player player;
    public Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        player =  GameObject.FindWithTag("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
                ui.enabled = true;
                Time.timeScale = 0;

            }

        if(player.hp <= 0){
            //换图片，显示画布，修改按钮文字
            image.GetComponent<image>().die = true;
            text.GetComponent<TMP_Text>().text = "Retry";
            ui.enabled = true;
            Time.timeScale = 0;
            
        }

        if(player.win){
            image.GetComponent<image>().win = true;
            text.GetComponent<TMP_Text>().text = "Replay";
            ui.enabled = true;
            Time.timeScale = 0;

        }
    }


    public void buttonclick(){
                if(player.hp >0 && ! player.win){
                    ui.enabled = false;
                    text.GetComponent<TMP_Text>().text = "Continue";
                    Time.timeScale = 1;
                }
                else{
                    SceneManager.LoadScene(0);
                }
                
    }

    
}
