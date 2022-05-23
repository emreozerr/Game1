using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  public Transform FirePoint;
  public GameObject Bullet; 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            shoot();
        }
        void shoot(){
            Instantiate(Bullet, FirePoint.position, FirePoint.rotation); 
        }
    }
}
