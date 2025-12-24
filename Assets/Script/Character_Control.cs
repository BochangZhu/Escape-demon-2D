using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class CharacterControl : MonoBehaviour
{
    public float jump_strength; // Create a jump strength to test for the proper value
    private Rigidbody2D myRigidbody; // Create RigidBody2D variable
    public float mass_scale; // Create a mass_scale to control manually
    // private PolygonCollider2D myPolygonCollider; // Create a polygoncollider2d variable

    [SerializeField]
    private float gravity_scale;
    void Start()
    {
    //     Transform myTransform = gameObject.transform;
    //     myTransform.position = new Vector3(-6.76f, 0f, 0f);

        myRigidbody = gameObject.GetComponent<Rigidbody2D>(); // Add and store Rigidbody2D
        myRigidbody.mass = mass_scale; // Adjust the mass value
        myRigidbody.gravityScale = gravity_scale; //
        Debug.Log("Initializing myself.");

    //     myPolygonCollider = gameObject.AddComponent<PolygonCollider2D>(); // Add and store PolygonCollider2D

    //     name = "squirrel_character"; // Change the name of the character
    }
    
    private void OnJump(InputValue val)
    {
        Debug.Log("Jump detected");
        if (val.isPressed)
        {
            myRigidbody.linearVelocity = new Vector2(0, 1) * jump_strength;
        }
    }
}
