using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Keys Script;
    Animator myAnimator;
   public AudioSource src;
    void Start()
    {
        myAnimator = GetComponent<Animator> ();
    }

   
    void Update()
    {
        
        
    }
    void OnTriggerEnter2D(Collider2D other){
         if(other.gameObject.CompareTag("Player") && Script.key ==5){
            myAnimator.SetTrigger("IsOpen");
            src.Play();
           
         }
        
    }
    
}
