using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finish : MonoBehaviour
{
    public void ReturnToGameOverScreen(){
        SceneManager.LoadScene(3);
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player1")){

            ReturnToGameOverScreen();
           // collision.GetComponent<PlayerMovement>().damagee(2);
            
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
