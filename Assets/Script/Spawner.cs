using UnityEngine;

public class Spawner : MonoBehaviour{

[SerializeField] 
private GameObject pipe;
float timer = 0f;

private float sp_freq;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        this.enabled = false;
        DontDestroyOnLoad(gameObject);


    }

    // Update is called once per frame
    void Start()
    {
        GameObject temp = Instantiate(pipe);
        temp.tag = "pipe";
        GameObject top_pipe = temp.transform.Find("top_pipe").gameObject;
        top_pipe.tag = "pipe";
        sp_freq = Random.Range(0.75f, 3f);
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= sp_freq)
        {
            GameObject temp = Instantiate(pipe);
            temp.tag = "pipe";
            GameObject top_pipe = temp.transform.Find("top_pipe").gameObject;
            top_pipe.tag = "pipe";
            timer = 0f;
            sp_freq = Random.Range(0.75f, 3f);
        }
        
    }

}
