using UnityEngine;

public class top_detection : MonoBehaviour
{
    public GameObject main_char;
    public GameObject sp;
    public PolygonCollider2D cld;
    void Awake()
    {
        sp = GameObject.Find("Pipe_Spawner");
        main_char = GameObject.Find("char");      
    }

    void Start(){
        cld = gameObject.GetComponent<PolygonCollider2D>();
        if (cld == null)
        {
            Debug.LogWarning("PolygonCollider2D not found, adding one...");
            cld = gameObject.AddComponent<PolygonCollider2D>();
        }
        cld.isTrigger = true;     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something Enters.");
        if (other.gameObject == main_char)
        {
            Destroy(main_char);
            Destroy(sp);
        }
    }

}
