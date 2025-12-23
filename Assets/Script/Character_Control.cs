using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float jump_strength; // Create a jump strength to test for the proper value
    private Rigidbody2D myRigidbody; // Create RigidBody2D variable
    public float mass_scale; // Create a mass_scale to control manually
    private PolygonCollider2D myPolygonCollider; // Create a polygoncollider2d variable

    [SerializeField]
    private float gravity_scale;
    void Start()
    {
        Transform myTransform = gameObject.transform;
        myTransform.position = new Vector3(-6.76f, 0f, 0f);

        myRigidbody = gameObject.AddComponent<Rigidbody2D>(); // Add and store Rigidbody2D
        myRigidbody.mass = mass_scale; // Adjust the mass value
        myRigidbody.gravityScale = gravity_scale; //

        myPolygonCollider = gameObject.AddComponent<PolygonCollider2D>(); // Add and store PolygonCollider2D

        name = "squirrel_character"; // Change the name of the character
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space")){ // If space is pressed, give the character's an upward velocity
            myRigidbody.linearVelocity = new Vector2(0, 1) * jump_strength;
        }
    }
}
