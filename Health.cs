using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
  public GameObject Heart1;
  public GameObject Heart2;
  public GameObject Heart3;
  public AudioSource src;
 
  public int health;
  CircleCollider2D myBodyCollider;
    void Start()
    {
       myBodyCollider = GetComponent<CircleCollider2D>();
    }

   
    void Update()
    {
        
        Die();
    
        switch (health)
        {
            
            case 0:
            {
                Heart1.gameObject.SetActive (false);
                Heart2.gameObject.SetActive (false);
                Heart3.gameObject.SetActive (false);
                break;
            }
            case 1:
            {
                Heart1.gameObject.SetActive (true);
                Heart2.gameObject.SetActive (false);
                Heart3.gameObject.SetActive (false);
                break;
            }
            case 2:
            {
                Heart1.gameObject.SetActive (true);
                Heart2.gameObject.SetActive (true);
                Heart3.gameObject.SetActive (false);
                break;
            }
            case 3:
            {
                Heart1.gameObject.SetActive (true);
                Heart2.gameObject.SetActive (true);
                Heart3.gameObject.SetActive (true);
                break;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("heart")){
            health--;
            src.Play();
            

        }}
    void Die()
    {
        if (health==0)
        {
            SceneManager.LoadScene(3);
	      
        }
    }
     
}
