using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    // TMPro is a text mesh pro library that allows us to use text in our game
    // in contrast to other text objects it has vector-based rendering and looks more crips
    private TextMeshProUGUI m_TextMeshPro;

    private float points = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        m_TextMeshPro = GetComponent<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        // We count up the number of points unless the player object became null (has been killed)
        if (player != null)
        {
            points += Time.deltaTime;
            m_TextMeshPro.text = ((int)points).ToString();
        }
        
    }
}
