using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
  public GameObject key1;
  public GameObject key2;
  public GameObject key3;
  public GameObject key4;
  public GameObject key5;
  public GameObject door;
  public AudioSource src;
  
  
  public int key;
  CircleCollider2D myBodyCollider;
    void Start()
    {
       myBodyCollider = GetComponent<CircleCollider2D>();
       
    }

   
    void Update()
    {
       
        switch (key)
        {
            
            case 0:
            {
                key1.gameObject.SetActive (false);
                key2.gameObject.SetActive (false);
                key3.gameObject.SetActive (false);
                key4.gameObject.SetActive (false);
                key5.gameObject.SetActive (false);
                break;
            }
            case 1:
            {
                key1.gameObject.SetActive (true);
                key2.gameObject.SetActive (false);
                key3.gameObject.SetActive (false);
                key4.gameObject.SetActive (false);
                key5.gameObject.SetActive (false);
                break;
            }
            case 2:
            {
                key1.gameObject.SetActive (true);
                key2.gameObject.SetActive (true);
                key3.gameObject.SetActive (false);
                key4.gameObject.SetActive (false);
                key5.gameObject.SetActive (false);
                break;
            }
            case 3:
            {
                key1.gameObject.SetActive (true);
                key2.gameObject.SetActive (true);
                key3.gameObject.SetActive (true);
                key4.gameObject.SetActive (false);
                key5.gameObject.SetActive (false);
                break;
            }
            case 4:
            {
                key1.gameObject.SetActive (true);
                key2.gameObject.SetActive (true);
                key3.gameObject.SetActive (true);
                key4.gameObject.SetActive (true);
                key5.gameObject.SetActive (false);
                break;
            }
            case 5:
            {
                key1.gameObject.SetActive (true);
                key2.gameObject.SetActive (true);
                key3.gameObject.SetActive (true);
                key4.gameObject.SetActive (true);
                key5.gameObject.SetActive (true);
                break;
            }
        }
    }
    
      void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("key")){
            key++;
            Destroy(other.gameObject);
            src.Play();

        }
        if(other.gameObject.CompareTag("Treasure") && key==5){
           
            Destroy(door);

        }
       
    }
   
   
}

