using UnityEngine;

public class Spawner : MonoBehaviour{

[SerializeField] 
private GameObject pipe;
float timer = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        this.enabled = false;

    }

    // Update is called once per frame
    void Start()
    {
        Instantiate(pipe);
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            Instantiate(pipe);
            timer = 0f;
        }
        
    }
    private void OnDestroy() {
        this.enabled = false;
    }
}
