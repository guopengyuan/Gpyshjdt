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
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( transform.right * dir.x *8 * Time.deltaTime);
        transform.Translate( transform.up * dir.y * 8 * Time.deltaTime );
    }
}
