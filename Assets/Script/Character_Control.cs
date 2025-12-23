using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float jump_strength;
    private Rigidbody2D myRigidbody;
    public float mass_scale;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.mass = mass_scale;
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space")){
            myRigidbody.linearVelocity = new Vector2(0, 1) * jump_strength;
        }
    }
}
