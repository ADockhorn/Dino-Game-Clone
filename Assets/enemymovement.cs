using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // since enemies won't require a rigidbody component, we can just move their transform 
        // (position, rotation, scale of the game object) to the left
        // every script that inherits from MonoBehaviour has a transform and a gameobject property
        transform.position += Vector3.left * Time.deltaTime * speed;  
        
        // if the enemy goes off the screen, destroy it
        if (transform.position.x < -13.95)
        {
            Destroy(gameObject);
        }
    }

   
}
