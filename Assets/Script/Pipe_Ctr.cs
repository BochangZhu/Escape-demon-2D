using UnityEngine;

public class Pipe_Ctr : MonoBehaviour
{
    public SpriteRenderer pipe_sr;
    public PolygonCollider2D pipe_cld;
    public Sprite column_img;

    private Transform pipe_tr;

    // public GameObject par_pipe; // Use as a reference to Setparent method to set it as the parent
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Assign variables to the added components(SpriteRender & Collider & Transform)
        pipe_sr = gameObject.AddComponent<SpriteRenderer>();
        pipe_sr.sprite = column_img;
        pipe_cld = gameObject.AddComponent<PolygonCollider2D>();
        pipe_tr = transform;
        name = "Pipe_Prefab";
        // Set the position& scale to the proper value
        pipe_tr.position = new Vector3(0, 3.94f, 0);
        pipe_tr.localScale = new Vector3(1.72f, 2.29f, 1.72f);

        // Create an exact copy of the current gameobject
        // GameObject buttom_pipe = Instantiate(gameObject);

        // Duplicate isn't enough, we need to rename and change pos
        // buttom_pipe.name = "buttom_pipe";
        // Transform buttom = buttom_pipe.transform;
        // buttom.position = new Vector3(0, -3.94f, 0);
        // buttom.localScale = new Vector3(1.72f, -2.29f, 1.72f);


        // This copy (buttom_pipe) set its parent as the par_pipe
        // buttom_pipe.transform.SetParent(par_pipe.transform, true); // Need to use true because the buttom pipe need to have its own position


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
