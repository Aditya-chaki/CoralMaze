using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    BoxCollider2D myBodyCollider;
    void Start()
    {
         myBodyCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myBodyCollider.IsTouchingLayers(LayerMask.GetMask("player"))){
            SceneManager.LoadScene(4);
        }
    }
}
