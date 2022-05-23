using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    //[SerializeField] private AudioSource takeItemEffect;
   private void OnTriggerEnter2D(Collider2D temas) {
       if(temas.gameObject.tag == "Player1"){
            //takeItemEffect.Play();
           ScoreGenerator.yildizpuani_int += 1; 
           Destroy(this.gameObject);
       }
       
   }
}
