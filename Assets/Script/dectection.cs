using UnityEngine;

public class detection: MonoBehaviour
{
    public GameObject sp;
    public PolygonCollider2D cld;
    void Awake()
    {
        sp = GameObject.Find("Pipe_Spawner");   
    }

    void Start(){
        cld = gameObject.GetComponent<PolygonCollider2D>();
        cld.isTrigger = true;     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something Enters.");
        
        Destroy(sp);

        GameObject[] objToDestroy = GameObject.FindGameObjectsWithTag("pipe");
        foreach (GameObject obj in objToDestroy)
        {
            Destroy(obj);
        }
        Destroy(gameObject);


    }

}
