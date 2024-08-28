using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Keys Script;
    BoxCollider2D myBodyCollider;

    void Start()
    {
        myBodyCollider = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        if (myBodyCollider.IsTouchingLayers(LayerMask.GetMask("player"))){
           if(Script.key==5){
            Destroy(gameObject);
           }

        }
    }
}
