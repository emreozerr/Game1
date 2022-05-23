using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diken : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player1")){

            collision.GetComponent<PlayerMovement>().damagee(2);
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
