using UnityEngine;

public class Score_Dec : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something enters, donno if it's a pipe.");
        if (other.gameObject.CompareTag("pipe"))
        {
            score_man.instance.increment_score();
        }
    }
    
}
