using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharacter : MonoBehaviour
{
    // we can set the jump force in the inspector since the variable is public
    public float jumpForce = 5f;

    // we need a reference to the rigidbody component to add force to it
    // the GetComponent function is quite inefficient, which is why we want to
    // use it only once in Start in store the reference in a variable
    private Rigidbody2D rb;

    // we need to know if the character is on the ground to allow jumping
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        // GetComponent can be used to get a reference to any component on the
        // game object that the current script is attached to
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // we can use raycasts to check if the character is on the ground
        // here we are casting a ray from the character's position downwards
        // if the ray hits objects that are on the "Ground", the character is assumed to be on the ground
        grounded = false;
        if (Physics2D.Raycast(transform.position, Vector2.down,1, LayerMask.GetMask("Ground")))
        {
            grounded = true;
        }

        // if the space key is pressed and the character is on the ground, add an upward force
        // GetKeyDown is true only on the frame that the key is pressed
        if (Input.GetKeyDown(KeyCode.Space) && grounded) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
