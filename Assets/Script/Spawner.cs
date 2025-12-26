using UnityEngine;

public class Spawner : MonoBehaviour{

[SerializeField] 
private GameObject pipe;
public Transform parent_pipe;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        this.enabled = false;

    }

    // Update is called once per frame
    void OnEnable() {
        parent_pipe = new GameObject("Pipe").transform;
        GameObject top_pipe = Instantiate(pipe, parent_pipe);
        top_pipe.name = "top_pipe";
        GameObject buttom_pipe = Instantiate(pipe, new Vector3(0, -3.94f, 0), Quaternion.identity, parent_pipe);
        buttom_pipe.name = "buttom_pipe";
        buttom_pipe.transform.localScale = new Vector3(1.72f, -2.29f, 1.72f);
    }
    void Update()
    {
        
    }
}
