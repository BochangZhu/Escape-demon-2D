using UnityEngine;
using System;

public class Remove_And_Start : MonoBehaviour
{
    private InputProvider prov;
    public GameObject sqr_prefab;
    private PolygonCollider2D cld;

    public GameObject SP;
    void Awake() {
        SP = GameObject.Find("Pipe_Spawner");
        prov = FindFirstObjectByType<InputProvider>(); // Use FFOBT fucntion to get the script type object(not a game object)
        cld = gameObject.AddComponent<PolygonCollider2D>(); // Create PolygonCollider2D with outline editted in my sprite editor
        cld.isTrigger = true; // Set is trigger equals to true
        sensor();
        if (prov != null) // If the script type actually exists and store successfully
        {
            Debug.Log($"Found the object {prov.name}."); // Send a messages to the console
        }
        prov.clicked += spawn_char;
    }

    void Update()
    {
        sensor();
    }
    private void sensor()
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
        if (!(cld.OverlapPoint(prov.WorldPosition))) return;
        // Unsubscribe from listener list
        prov.clicked -= spawn_char;

        // 2. DISABLE the Menu Input FIRST
        // This forces it to drop the Keyboard immediately.
        prov.enabled = false; 
        // OR just destroy it now if you don't need data from it anymore
        // Destroy(prov.gameObject); 

        // 3. NOW Spawn the Squirrel
        // Since the Menu is dead/disabled, the Keyboard is free.
        // The Squirrel sees the free keyboard and grabs it.

        GameObject temp = Instantiate(sqr_prefab);
        temp.name = "char";
        SP.GetComponent<Spawner>().enabled = true;

        // 4. Hide the button visual
        Destroy(gameObject);

    }

}
