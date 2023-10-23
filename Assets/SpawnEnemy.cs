using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Here we store multiple types of GameObject Prefabs that can be spawned copies of
    // We can also use an array or list to store multiple of them
    public GameObject enemyPrefabFlying;
    public GameObject enemyPrefabWalking;

    // we can use the SerializeField attribute to make a private variable visible in the inspector
    // this ensures that other scripts cannot change the value of the variable, but we can still change it in the inspector
    [SerializeField]
    private float spawnRate = 1f;

    public GameObject restartObject;


    private float coolDown;

    // Start is called before the first frame update
    void Start()
    {
        coolDown = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        // deltaTime is the time in seconds it took to render the last frame
        // we can use this to make sure that the game runs at the same speed on different computers
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            // Instantiate is a function that creates a copy of a game object
            GameObject go;
            if (Random.Range(0,2) < 1)
            {
                go = Instantiate<GameObject>(enemyPrefabWalking, transform.position, Quaternion.identity);
                
            } else
            {
                // For the flying opponent, we will use a slight offset in y-direction.
                go = Instantiate<GameObject>(enemyPrefabFlying, transform.position, Quaternion.identity);
                go.transform.position += Vector3.up;
            }

            // setting the parent will show the current game object as child of the parent in the scene hierarchy
            go.transform.parent = transform;
            coolDown = spawnRate;

            // we will be setting the restartButton variable such that the enemy can later access it
            go.GetComponent<PlayerDeath>().restartButton = restartObject;

        }

    }
}
