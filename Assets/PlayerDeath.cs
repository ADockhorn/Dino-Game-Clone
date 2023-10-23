using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    // This variable will be set by the SpawnEnemy script
    // every time an enemy is spawned.
    public GameObject restartButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // OnCollisionEnter2D is called when the game object collides with another game object
        // the collision parameter contains information about the collision
        if (collision.gameObject.tag == "Player")
        {
            // we can use the Destroy function to destroy a game object of the player
            Destroy(collision.gameObject);

            // we can use the SetActive function to enable or disable a game object
            restartButton.SetActive(true);
        }
    }
}
