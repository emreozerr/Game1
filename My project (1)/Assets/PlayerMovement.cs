using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
     [SerializeField] private AudioSource takeItemEffect;
    private void OnTriggerEnter2D(Collider2D temas) {
       if(temas.gameObject.tag == "Player1"){
            takeItemEffect.Play();
           //ScoreGenerator.yildizpuani_int += 1; 
           //Destroy(this.gameObject);
       }  
   }





    public int healt = 1;
    Rigidbody2D rgb;
    Vector3 velocity;
   // Vector3 scale;
    public Animator animator; 
    float speedAmount = 7f;
    float jumoAmount = 7f;  
    float horizontal;
   // bool lookright = true;
    // Start is called before the first frame update
    [SerializeField] private AudioSource jumpSoundEffect;
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
       transform.position += velocity * speedAmount * Time.deltaTime; 

        if(Input.GetButtonDown("Jump")&& Mathf.Approximately(rgb.velocity.y, 0)){

          //  jumpSoundEffect.Play();
            rgb.AddForce(Vector3.up * jumoAmount, ForceMode2D.Impulse);
            animator.SetBool("jumping", true);
        }
        
        if (animator.GetBool("jumping") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("jumping", false);
        }

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

       /*if (Input.GetAxisRaw("Horizontal") == -1) 
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
            else if(Input.GetAxisRaw("Horizontal") == 1){
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            } */

       /* if( Input.GetAxisRaw("Horizontal") > 0 && lookright == false){
            turn();
        }
       if(Input.GetAxisRaw("Horizontal") < 0 && lookright == true){
        turn();
        }*/
            
    }
    
    /* void turn(){
            lookright = !lookright;
            scale = gameObject.transform.localScale;
            scale.x = scale.x * (-1);
            gameObject.transform.localScale = scale;  
           // transform.Rotate(new Vector3(0,180,0));
        }*/
        [SerializeField] private AudioSource deathSoundEffect;
        public void ReturnToGameOverScreen(){
          //  deathSoundEffect.Play();
        SceneManager.LoadScene(4);
        
        
    }
        
         public void damagee(int damage)
    {
        

        healt -= damage;
        if (healt <= 0)
        {
           
            Die();
        }
    
         void Die()
        {
            Destroy(gameObject);
            ReturnToGameOverScreen();

        }
    }
}
