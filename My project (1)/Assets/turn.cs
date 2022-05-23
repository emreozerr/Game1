using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    Vector3 scale;
    bool lookright = true;
    void turn_f(){
            lookright = !lookright;
            /*scale = gameObject.transform.localScale;
            scale.x = scale.x * (-1);
            gameObject.transform.localScale = scale; */

            transform.Rotate(new Vector3(0,180,0));
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetAxisRaw("Horizontal") > 0 && lookright == false){
            turn_f();
        }
       if(Input.GetAxisRaw("Horizontal") < 0 && lookright == true){
        turn_f();
        }
    }
}
