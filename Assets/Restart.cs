using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        // we can only load scenes that are in the build order
        // we can get the current scene's build index with SceneManager.GetActiveScene().buildIndex
        // and restart it, by loading it again
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
