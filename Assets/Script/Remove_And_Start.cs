using UnityEngine;
using System;

public class Remove_And_Start : MonoBehaviour
{
    private InputProvider prov;
    public GameObject sqr_prefab;
    private PolygonCollider2D cld;
    void Awake() {
        cld = gameObject.AddComponent<PolygonCollider2D>();
        cld.isTrigger = true;
        prov = FindFirstObjectByType<InputProvider>();
        if (prov != null)
        {
            Debug.Log($"Found the object {prov.name}.");
        }
        prov.clicked += spawn_char;
    }

    void Update()
    {
        if (cld.OverlapPoint(prov.WorldPosition))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white; 
        }
    }

    private void spawn_char()
    {      
        // 1. Unsubscribe (Cleanup)
        prov.clicked -= spawn_char;

        // 2. DISABLE the Menu Input FIRST
        // This forces it to drop the Keyboard immediately.
        prov.enabled = false; 
        // OR just destroy it now if you don't need data from it anymore
        Destroy(prov.gameObject); 

        // 3. NOW Spawn the Squirrel
        // Since the Menu is dead/disabled, the Keyboard is free.
        // The Squirrel sees the free keyboard and grabs it.
        Instantiate(sqr_prefab);        

        // 4. Hide the button visual
        gameObject.SetActive(false);

    }

}
