using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    
     void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("key")){
            Destroy(other.gameObject);
        }
    }

}
