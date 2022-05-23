using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public int healt = 2;
    Rigidbody2D rb;
    public void damage(int damage)
    {
        healt -= damage;
        if (healt <= 0)
        {
           
            Die();
        }

        void Die()
        {
            ScoreGenerator.yildizpuani_int += 3; 
            Destroy(gameObject);
        }
    }


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
