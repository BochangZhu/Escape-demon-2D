using UnityEngine;
using System;
using UnityEngine.InputSystem;


public class detection: MonoBehaviour
{
    public Spawner sp;
    public PolygonCollider2D cld;
    private PlayerInput my_input;
    private Rigidbody2D my_rigid;

    public GameObject start_prefab;

    public InputProvider system_input;



    void Start(){
        system_input = FindFirstObjectByType<InputProvider>();
        sp = FindFirstObjectByType<Spawner>();   
        my_input = gameObject.GetComponent<PlayerInput>();// Get the playerinput
        my_rigid = gameObject.GetComponent<Rigidbody2D>();
        cld = gameObject.GetComponent<PolygonCollider2D>();
        cld.isTrigger = true;     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        gameover();

    }
    private void gameover()
    {
        Debug.Log("GG");

        score_man.instance.score_reset();
        
        sp.disable_sp();

        my_input.DeactivateInput();

        GameObject[] objToDestroy = GameObject.FindGameObjectsWithTag("pipe");
        foreach (GameObject obj in objToDestroy)
        {
            Destroy(obj);
        }
        Destroy(gameObject);
    }
    void Update()
    {
        if ((transform.position.y > 4.5) || (transform.position.y < -5.7))
        {
            gameover();
        }
    }

    void OnDestroy()
    {
        system_input.enabled = true;
        Instantiate(start_prefab);
    }
}
