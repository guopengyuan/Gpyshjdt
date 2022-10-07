using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class image : MonoBehaviour
{
    public bool die;
    public bool win;
    Sprite sprite ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(die){
            sprite = Resources.Load<Sprite>("image2811");
            transform.GetComponent<Image>().sprite = sprite;
            
        }

        if(win){
            sprite = Resources.Load<Sprite>("image2766");
            transform.GetComponent<Image>().sprite = sprite;
        }
    }
}
